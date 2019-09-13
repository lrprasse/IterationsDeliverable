using System;

namespace IterationsDeliverable
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please enter an integer between 1 and 100: ");
                string input = Console.ReadLine();
                int value = int.Parse(input);

                if (value > 0 && value < 101)
                {
                    for (int i = 1; i <= value; i++)
                    {
                        Console.WriteLine("You have entered " + value.ToString() + "." +
                            " This is the current integer value in the loop: " + i.ToString());
                        Console.Beep();
                        System.Threading.Thread.Sleep(500);
                    }
                }
                else
                {
                    Console.WriteLine("The integer you entered is not between 1 and 100.");
                }
            }
            catch
            {
                Console.WriteLine("Something went wrong! Please restart the program and" +
                    "enter a valid integer.");
            }
        }
    }
}
