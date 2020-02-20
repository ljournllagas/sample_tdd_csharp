using System;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            int yesCounter = 4;
            int noCounter = 2;
            int maybeCounter = 3;

            int total = yesCounter + noCounter + maybeCounter;

            var yesPercent = Math.Round(yesCounter * 100.0 / total, 2);
            var noPercent = Math.Round(noCounter * 100.0 / total, 2);
            var maybePercent = Math.Round(maybeCounter * 100.0 / total, 2);

            var excess = Math.Round(100 - yesPercent - noPercent - maybePercent, 2);
           
            if (yesCounter > noCounter)
            {
                if (yesCounter > maybeCounter)
                {
                    Console.WriteLine($"Yes won");
                    yesPercent += excess;

                } else if(maybeCounter > yesCounter)
                {
                    Console.WriteLine($"Maybe won");
                    maybePercent += excess;
                }
                else
                {
                    noPercent += excess;
                    Console.WriteLine("It's a draw");
                }
                
            }
            else if (noCounter > yesCounter)
            {
                if (noCounter > maybeCounter)
                {
                    Console.WriteLine($"No won");
                    noPercent += excess;
                }
                else if (maybeCounter > noCounter)
                {
                    Console.WriteLine($"Maybe won");
                    maybePercent += excess;
                }
                else
                {
                    Console.WriteLine("It's a draw");
                    yesPercent += excess;
                }

            }
            else if (maybeCounter > yesCounter)
            {
                Console.WriteLine($"Maybe won");
                maybePercent += excess;
            }
            else
            {
                Console.WriteLine("It's a draw");
            }

            Console.WriteLine($"Yes counts: {yesCounter}, Percentage: {Math.Round(yesPercent,2)}%");
            Console.WriteLine($"No counts: {noCounter}, Percentage: {Math.Round(noPercent,2)}%");
            Console.WriteLine($"Maybe counts: {maybeCounter}, Percentage: {Math.Round(maybePercent,2)}%");

        }
    }
}

