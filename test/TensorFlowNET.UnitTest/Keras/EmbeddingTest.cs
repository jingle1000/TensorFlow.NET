﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Tensorflow.Keras.Engine;
using Tensorflow.Keras.Layers;
using NumSharp;

namespace TensorFlowNET.UnitTest.Keras
{
    /// <summary>
    /// https://www.tensorflow.org/versions/r1.14/api_docs/python/tf/keras/layers/Embedding
    /// </summary>
    [TestClass]
    public class EmbeddingTest
    {
        [TestMethod]
        public void Embedding()
        {
            var model = new Sequential();
            model.add(new Embedding(1000, 64, input_length: 10));
            // the model will take as input an integer matrix of size (batch,
            // input_length).
            // the largest integer (i.e. word index) in the input should be no larger
            // than 999 (vocabulary size).
            // now model.output_shape == (None, 10, 64), where None is the batch
            // dimension.
            var input_array = np.random.randint(1000, size: (32, 10));
            model.compile("rmsprop", "mse");
        }
    }
}
