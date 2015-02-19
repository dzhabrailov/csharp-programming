using System;
using System.Linq;


namespace MaxiSequence
{
    class SequenceOfEqualElements
    {
        /// <summary>
        /// Problem 4. Maximal sequence
        /// Write a program that finds the maximal sequence of equal elements in an array.
        /// </summary>
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Set your array lenght: ");
                int inputElements = int.Parse(Console.ReadLine());

                //declare array
                int[] sequenceArray = new int[inputElements];
                //initialize indexes
                for (int i = 0; i < sequenceArray.Length; i++)
                {
                    sequenceArray[i] = int.Parse(Console.ReadLine());
                }

                FindMaxSequence(sequenceArray);
            }
        }

        /// <summary>
        /// This method find maximal sequence of equal elements in the array. 
        /// I use LINQ to find sequence.
        /// </summary>
        /// <param name="sequenceArray"></param>
        private static void FindMaxSequence(int[] sequenceArray)
        {
            int[] max = sequenceArray.Select((n, i) => new { Value = n, Index = i }).OrderBy(s => s.Value)
                .Select((o, i) => new { Value = o.Value, Diff = i - o.Index }).GroupBy(s => new { s.Value, s.Diff })
                .OrderByDescending(g => g.Count()).First().Select(f => f.Value).ToArray();

            if (max.Length >= 2)
            {
                string arrayContetn = string.Join(" ", sequenceArray);
                string result = string.Join(", ", max);

                Console.WriteLine(new string('-', 50));
                Console.WriteLine("Your array content these numbers [{0}] - and equal sequence is: {1}", arrayContetn, result);
            }
            else
            {
                Console.WriteLine(new string('-', 20));
                Console.WriteLine("There's no seqence.");
            }
        }
    }
}
