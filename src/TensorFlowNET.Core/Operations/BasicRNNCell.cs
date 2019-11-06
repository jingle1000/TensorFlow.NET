﻿/*****************************************************************************
   Copyright 2018 The TensorFlow.NET Authors. All Rights Reserved.

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
******************************************************************************/

using System;
using Tensorflow.Keras.Engine;
using static Tensorflow.Binding;

namespace Tensorflow
{
    public class BasicRnnCell : LayerRnnCell
    {
        int _num_units;
        Func<Tensor, string, Tensor> _activation;

        public override int state_size => _num_units;
        public override int output_size => _num_units;
        public VariableV1 _kernel;
        string _WEIGHTS_VARIABLE_NAME = "kernel";
        public VariableV1 _bias;
        string _BIAS_VARIABLE_NAME = "bias";

        public BasicRnnCell(int num_units,
            Func<Tensor, string, Tensor> activation = null,
            bool? reuse = null,
            string name = null,
            TF_DataType dtype = TF_DataType.DtInvalid) : base(_reuse: reuse, 
                name: name, 
                dtype: dtype)
        {
            // Inputs must be 2-dimensional.
            input_spec = new InputSpec(ndim: 2);

            _num_units = num_units;
            if (activation == null)
                _activation = math_ops.tanh;
            else
                _activation = activation;
        }

        protected override void build(TensorShape inputs_shape)
        {
            var input_depth = inputs_shape.dims[inputs_shape.ndim - 1];

            _kernel = add_weight(
                _WEIGHTS_VARIABLE_NAME,
                shape: new[] { input_depth + _num_units, _num_units });

            _bias = add_weight(
                _BIAS_VARIABLE_NAME,
                shape: new[] { _num_units },
                initializer: tf.zeros_initializer);

            built = true;
        }

        protected override Tensor[] call(Tensor inputs, Tensor training = null, Tensor state = null)
        {
            // Most basic RNN: output = new_state = act(W * input + U * state + B).
            var concat = array_ops.concat(new[] { inputs, state }, 1);
            var gate_inputs = math_ops.matmul(concat, _kernel as RefVariable);
            gate_inputs = nn_ops.bias_add(gate_inputs, _bias as RefVariable);
            var output = _activation(gate_inputs, null);
            return new[] { output, output };
        }
    }
}
