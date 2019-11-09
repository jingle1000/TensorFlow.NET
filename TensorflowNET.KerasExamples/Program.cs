using NumSharp;
using System;
using System.Collections.Generic;
using Tensorflow;
using static Tensorflow.Binding;
namespace TensorflowNET.KerasExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var work = new KerasRnn();
            work.Run();
        }
    }

    public class CharacterTable
    {
        public CharacterTable(string chars)
        {
            this.chars = chars.ToCharArray();
            this.char_indices = new Dictionary<char, int>();
            this.indices_char = new Dictionary<int, char>();
            CreateCharacterMappings();
        }
        private void CreateCharacterMappings()
        {
            foreach ((var i, var c) in enumerate(this.chars))
            {
                char_indices[c] = i;
                indices_char[i] = c;
            }
        }
        public char[] chars { get; set; }
        public Dictionary<char, int> char_indices { get; set; }
        public Dictionary<int, char> indices_char { get; set; }
        public NDArray encode(string C, int num_rows)
        {
            var x = np.zeros((num_rows, len(chars)));
            foreach ((var i, var c) in enumerate(chars))
            {
                x[i, char_indices[c]] = 1;
            }
            return x;
        }
    }
    class KerasRnn
    {
        public bool Enabled { get; set; } = true;
        public bool IsImportingGraph { get; set; } = true;

        public string Name => "Keras Rnn";

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
            var TRAINING_SIZE = 50000;
            var DIGITS = 3;
            var MAXLEN = DIGITS + 1 + DIGITS;

            var chars = "0123456789+ ";
            var ctable = new CharacterTable(chars);

            var questions = new List<string>();
            var expected = new List<int>();
            var seen = new List<(int, int)>();

            while (len(questions) < TRAINING_SIZE)
            {
                Func<int, int> f = x => new Random().Next(0, x);
                var a = f(1000);
                var b = f(1000);
                var key = a > b ? (a, b) : (b, a);


                if (seen.Contains(key))
                    continue;
                seen.Add(key);
                var q = $"{a}+{b}";
                var query = q.PadRight(MAXLEN);
                questions.Add(query);
                var ans = a + b;
                expected.Add(ans);
            }
            Console.WriteLine($"Now training for the following { len(questions) } questions.");

            //vectorization
            var x = np.zeros((len(questions), MAXLEN, len(chars)), NPTypeCode.Boolean);
            var y = np.zeros((len(questions), DIGITS + 1, len(chars)), NPTypeCode.Boolean);
            foreach ((var i, var sentence) in enumerate(questions))
            {
                x[i] = ctable.encode(sentence, MAXLEN);
                y[i] = ctable.encode(sentence, DIGITS + 1);
            }

            //# Shuffle (x, y) in unison as the later parts of x will almost all be larger
            //# digits.  
            var indices = np.arange(len(y));
            x = x[indices];
            y = y[indices];
            var split_at = len(x) - (len(x) / 10);

            var x_train = x[$":{split_at}"];
            var x_val = x[$"{split_at}:"];

            var y_train = y[$":{split_at}"];
            var y_val = y[$"{split_at}:"];
            Console.WriteLine('Training Data:');
            Console.WriteLine(x_train.shape);
            Console.WriteLine(y_train.shape);

            Console.WriteLine('Validation Data:');
            Console.WriteLine(x_val.shape);
            Console.WriteLine(y_val.shape);
            // Try replacing GRU, or SimpleRNN.
            var RNN = Tensorflow.keras.layers;
            var HIDDEN_SIZE = 128;
            var BATCH_SIZE = 128;
            var LAYERS = 1;

            return false;

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
