﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Tensorflow;
using static Tensorflow.Binding;

namespace TensorFlowNET.Examples.ImageProcessing.YOLO
{
    class common
    {
        public static Tensor convolutional(Tensor input_data, int[] filters_shape, Tensor trainable,
            string name, bool downsample = false, bool activate = true, 
            bool bn = true)
        {
            return tf_with(tf.variable_scope(name), scope =>
            {
                int[] strides;
                string padding;

                if (downsample)
                {
                    (int pad_h, int pad_w) = ((int)Math.Floor((filters_shape[0] - 2) / 2.0f) + 1, (int)Math.Floor((filters_shape[1] - 2) / 2.0f) + 1);
                    var paddings = tf.constant(new int[,] { { 0, 0 }, { pad_h, pad_h }, { pad_w, pad_w }, { 0, 0 } });
                    input_data = tf.pad(input_data, paddings, "CONSTANT");
                    strides = new[] { 1, 2, 2, 1 };
                    padding = "VALID";
                }
                else
                {
                    strides = new int[] { 1, 1, 1, 1 };
                    padding = "SAME";
                }

                var weight = tf.get_variable(name: "weight", dtype: tf.float32, trainable: true,
                    shape: filters_shape, initializer: tf.random_normal_initializer(stddev: 0.01f));

                var conv = tf.nn.conv2d(input: input_data, filter: weight, strides: strides, padding: padding);

                if (bn)
                {
                    conv = tf.layers.batch_normalization(conv, beta_initializer: tf.zeros_initializer,
                                                 gamma_initializer: tf.ones_initializer,
                                                 moving_mean_initializer: tf.zeros_initializer,
                                                 moving_variance_initializer: tf.ones_initializer, training: trainable);
                }
                else
                {
                    var bias = tf.get_variable(name: "bias", shape: filters_shape.Last(), trainable: true,
                       dtype: tf.float32, initializer: tf.constant_initializer(0.0f));
                    conv = tf.nn.bias_add(conv, bias);
                }

                if (activate)
                    conv = tf.nn.leaky_relu(conv, alpha: 0.1f);

                return conv;
            });
        }

        public static Tensor upsample(Tensor input_data, string name, string method = "deconv")
        {
            Debug.Assert(new[] { "resize", "deconv" }.Contains(method));
            Tensor output = null;
            if (method == "resize")
            {
                tf_with(tf.variable_scope(name), delegate
                {
                    var input_shape = tf.shape(input_data);
                    output = tf.image.resize_nearest_neighbor(input_data, new Tensor[] { input_shape[1] * 2, input_shape[2] * 2 });
                });
            }
            else if(method == "deconv")
            {
                throw new NotImplementedException("upsample.deconv");
            }

            return output;
        }

        public static Tensor residual_block(Tensor input_data, int input_channel, int filter_num1, 
            int filter_num2, Tensor trainable, string name)
        {
            var short_cut = input_data;

            return tf_with(tf.variable_scope(name), scope =>
            {
                input_data = convolutional(input_data, filters_shape: new int[] { 1, 1, input_channel, filter_num1 },
                                   trainable: trainable, name: "conv1");
                input_data = convolutional(input_data, filters_shape: new int[] { 3, 3, filter_num1, filter_num2 },
                                   trainable: trainable, name: "conv2");

                var residual_output = input_data + short_cut;

                return residual_output;
            });
        }
    }
}
