using NumSharp;
using System;
using System.Collections.Generic;
using System.Text;
using Tensorflow;

namespace TensorFlowNET.Examples.TextProcessing
{
    class LstmContentGeneration : IExample
    {
        public bool Enabled { get; set; } = true;
        public bool IsImportingGraph { get; set; } = false;
        public string Name => "LSTM Content Generation";

        string DATA_PATH = @"C:\src\Python\nlp\Natural-Language-Processing\MLPython\all-the-news\outfile.txt";

        int NUM_CLASS = 14;
        int BATCH_SIZE = 64;
        int NUM_EPOCHS = 10;
        int WORD_MAX_LEN = 100;
        int CHAR_MAX_LEN = 1014;

        float loss_value = 0;
        double max_accuracy = 0;

        int alphabet_size = -1;
        int vocabulary_size = -1;
        NDArray train_x, valid_x, train_y, valid_y;

        public Graph BuildGraph()
        {
            throw new NotImplementedException();
        }

        public Graph ImportGraph()
        {
            throw new NotImplementedException();
        }

        public void Predict(Session sess)
        {
            throw new NotImplementedException();
        }

        public void PrepareData()
        {
            throw new NotImplementedException();
        }

        public bool Run()
        {
            PrepareData();
            var graph = IsImportingGraph ? ImportGraph() : BuildGraph();

            using (var sess = tf.Session(graph))
                Train(sess);

            return max_accuracy > 0.9;
        }

        public void Test(Session sess)
        {
            throw new NotImplementedException();
        }

        public void Train(Session sess)
        {
            throw new NotImplementedException();
        }
    }
}
