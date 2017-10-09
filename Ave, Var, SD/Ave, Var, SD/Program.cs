using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ave__Var__SD
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running) { 
                Input();
                running = PromptDone();
             }            
        }

        static int[] Input()
        {
            Console.WriteLine("Input 5 whole integers separated by spaces");

            string[] input = Console.ReadLine().Split(null);

            int[] output = new int[input.Length];

            bool success = true;

            if (input.Length != 5)
                success = false;

            for (int i = 0; i < input.Length; i++)
            {
                if (success)
                success = Int32.TryParse(input[i], out output[i]);
            }

            if (!success)
                Console.WriteLine("Invalid Input");
            else
                foreach (var item in output)
                {
                    Console.WriteLine(item);
                }

            Console.ReadKey();
            Console.Clear();

            return output;
        }

        static bool PromptDone()
        {
            Console.WriteLine("Continue? (Y to continue, N to quit)");

            string answer = Console.ReadLine();

            Console.Clear();

            if (answer.ToLower().Contains('n'))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

