using System;

namespace MathsSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:

            Random numberGenerator = new Random ();

            int num01 = numberGenerator.Next(1,13);
            int num02 = numberGenerator.Next(1,13);

            Console.WriteLine ("What is "+ num01 + " x " + num02 + "?");

           int answer = Convert.ToInt32 (Console.ReadLine());
           if (answer == num01 * num02) {
               Console.WriteLine ("Correct! Well done. \nPress SPACE to answer another question.");
           } else {
               int responseIndex = numberGenerator.Next(1,4);
                
                switch (responseIndex) {
                case 1:
                    if (answer > num01 * num02)
                    Console.WriteLine ("You're a bit above the correct answer, but I believe in you! \nPress SPACE to try another question.");  
                    break;
                case 2:
                    if (answer < num01 * num02)
                    Console.WriteLine ("You're close, but your answer is below the correct answer. Try again! \nPress SPACE to try another question.");
                    break;
                default:
                    Console.WriteLine("Incorrect. Keep trying! \nPress SPACE to try another question.");
                    break;
                }

                
           }
            Console.ReadKey();
            goto Start;
        }
    }
}
