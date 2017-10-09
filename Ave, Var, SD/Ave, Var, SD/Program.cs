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

        /// <summary>
        /// This function handles the input from the user and returns an array of floats containing the 5 numbers selected by the user
        /// </summary>
        /// <returns></returns>
        static float[] Input()
        {
            // Prompt user for numbers
            Console.WriteLine("Input 5 whole integers separated by spaces");

            // Put the numbers into a string array
            string[] input = Console.ReadLine().Split(null);

            // Instantiate a float array that's just as long as the string array
            float[] output = new float[input.Length];

            // Instantiate bool success which is used to determine whether or not the user put in correctly formatted data
            bool success = true;

            // Test if the user inputted all 5 integers
            if (input.Length != 5)
                success = false;

            // For each number in the string array, attempt to put them in the float array
            for (int i = 0; i < input.Length; i++)
            {
                // If the program is successful up until this point, then try and put the number into the float array
                if (success)
                success = float.TryParse(input[i], out output[i]);
            }

            // If the user did something incorrectly, tell them they did or output the array of numbers
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
            // Bool used to loop the prompt
            bool prompting = true;

            while (prompting)
            {
                // Ask if they're done
                Console.WriteLine("Continue? (Y to continue, N to quit)");

                // Get user input and clear the console
                string answer = Console.ReadLine();

                Console.Clear();

                // Test if the user inputted an 'n' or 'y'
                if (answer.ToLower().Contains('n'))
                {
                    return false;
                }
                else if (answer.ToLower().Contains('y'))
                {
                    return true;
                }
                else
                {
                    // Clear console and retry if they didn't
                    prompting = true;
                    Console.Clear();
                }
            }
            return true;
        }
    }
}

