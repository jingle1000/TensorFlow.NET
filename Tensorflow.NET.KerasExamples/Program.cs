using NumSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using static PyExt.pyx;

namespace Tensorflow.NET.KerasExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class CharacterTable
    {
        public CharacterTable(List<char> characters)
        {
            this.chars = new SortedSet<char>();
            characters.ForEach(x => this.chars.Add(x));

        }
        public SortedSet<char> chars { get; set; }
        public Dictionary<int, char> char_indices()
        {
            var retval = new Dictionary<int, char>();
            int counter = 0;
            foreach (var c in chars)
            {
                retval[counter] = c;
                counter++;
            }
            return retval;
        }
        public Dictionary<char, int> indice_chars()
        {
            var retval = new Dictionary<char, int>();
            int counter = 0;
            foreach (var c in chars)
            {
                retval[c] = counter;
                counter++;
            }
            return retval;
        }
        public NDArray encode(string C, int num_rows)
        {
            var x = np.zeros((num_rows, len(chars)));
            foreach ((var i, var c) in enumerate(C))
            {
                x[i, this.char_indices()[c]] = 1;
            }
            return x;
        }
        public NDArray decode(List<char> x)
        {
            return string.Join("", x.Select(y => this.indice_chars()[y]).ToList());
        }

    }
    public class KerasAdditionRnn
    {
        public bool Enabled { get; set; } = true;
        public bool IsImportingGraph { get; set; } = false;

        public string Name => "Addition RNN";
        public int TRAINING_SIZE => 50000;
        public int DIGITS => 3;
        public bool REVERSE => true;

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
            var chars = "0123456789+ ";
            var ctable = new CharacterTable(chars.ToList());
            var questions = new List<NDArray>();
            var expected = new List<NDArray>();
            var seen = new SortedSet<Tuple<int, int>>();
            Console.WriteLine("Generating Data");
            while (len(questions) < this.TRAINING_SIZE)
            {
                var a = np.random.randint(0, 10000, new Shape(1)).Data<int>()[0];
                var b = np.random.randint(0, 10000, new Shape(1)).Data<int>()[0];
                var key = a > b ? new Tuple<int, int>(a, b) : new Tuple<int, int>(b, a);

                if (!seen.Contains(key))
                    seen.Add(key);


            }
            return true;
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
