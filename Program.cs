using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the amount in dollars: ");
        decimal amount = 0.0m;
        bool flagValid = false;
        do
        {
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.Write("Invalid input. Please enter a valid amount in dollars: ");
            }
            else
            {
                flagValid = decimal.TryParse(input, out amount);
            }

        } while (!flagValid);

        int amountInCents = (int)(amount * 100);

        if (amountInCents < 0)
        {
            Console.WriteLine("Invalid amount. Please enter a positive value.");
            return;
        }

        Console.WriteLine($"Amount in cents: {amountInCents}\n");


        {
            Console.WriteLine("Coin Analysis Using A Foreach Loop:");

            var timeAnalysis = new System.Diagnostics.Stopwatch();
            timeAnalysis.Start();

            for (int i = 0; i < 1000000; i++)
            {
                string text = coinAnalysisUsingALoop(amountInCents);
            }

            timeAnalysis.Stop();

            Console.WriteLine($"Result:\n{coinAnalysisUsingALoop(amountInCents)}");

            Console.WriteLine($"Time taken for analysis: {timeAnalysis.ElapsedMilliseconds} ms");
        }

        Console.WriteLine("---o---");

        {
            Console.WriteLine("Coin Analysis Using Brace Blocks:");

            var timeAnalysis = new System.Diagnostics.Stopwatch();
            timeAnalysis.Start();

            for (int i = 0; i < 1000000; i++)
            {
                string text = coinAnalysisUsingBraceBlocks(amountInCents);
            }

            timeAnalysis.Stop();

            Console.WriteLine($"Result:\n{coinAnalysisUsingBraceBlocks(amountInCents)}");

            Console.WriteLine($"Time taken for analysis: {timeAnalysis.ElapsedMilliseconds} ms");
        }
    }

    static string coinAnalysisUsingALoop(int amountInCents)
    {
        // Array of denominations in cents
        int[] denominations = { 10000, 5000, 2000, 1000, 500, 100, 25, 10, 5, 1 };
        string textMessage = string.Empty;

        // Calculate the number of each denomination needed
        foreach (int denomination in denominations)
        {
            int count = amountInCents / denomination;
            if (count > 0)
            {
                if (denomination >= 100)
                {
                    textMessage += $"{count} x ${denomination / 100} bill(s)\n";
                }
                else
                {
                    textMessage += $"{count} x {denomination / 100.0:C} coin(s)\n";
                }

                amountInCents %= denomination;
            }
        }

        return textMessage;
    }

    static string coinAnalysisUsingBraceBlocks(int amountInCents)
    {
        string textMessage = string.Empty;
        int denomination = 0;

        denomination = 10000;
        {
            int count = amountInCents / denomination;
            if (count > 0)
            {
                if (denomination >= 100)
                {
                    textMessage += $"{count} x ${denomination / 100} bill(s)\n";
                }
                else
                {
                    textMessage += $"{count} x {denomination / 100.0:C} coin(s)\n";
                }

                amountInCents %= denomination;
            }
        }

        denomination = 5000;
        {
            int count = amountInCents / denomination;
            if (count > 0)
            {
                if (denomination >= 100)
                {
                    textMessage += $"{count} x ${denomination / 100} bill(s)\n";
                }
                else
                {
                    textMessage += $"{count} x {denomination / 100.0:C} coin(s)\n";
                }

                amountInCents %= denomination;
            }
        }

        denomination = 2000;
        {
            int count = amountInCents / denomination;
            if (count > 0)
            {
                if (denomination >= 100)
                {
                    textMessage += $"{count} x ${denomination / 100} bill(s)\n";
                }
                else
                {
                    textMessage += $"{count} x {denomination / 100.0:C} coin(s)\n";
                }

                amountInCents %= denomination;
            }
        }

        denomination = 1000;
        {
            int count = amountInCents / denomination;
            if (count > 0)
            {
                if (denomination >= 100)
                {
                    textMessage += $"{count} x ${denomination / 100} bill(s)\n";
                }
                else
                {
                    textMessage += $"{count} x {denomination / 100.0:C} coin(s)\n";
                }

                amountInCents %= denomination;
            }
        }

        denomination = 500;
        {
            int count = amountInCents / denomination;
            if (count > 0)
            {
                if (denomination >= 100)
                {
                    textMessage += $"{count} x ${denomination / 100} bill(s)\n";
                }
                else
                {
                    textMessage += $"{count} x {denomination / 100.0:C} coin(s)\n";
                }

                amountInCents %= denomination;
            }
        }

        denomination = 100;
        {
            int count = amountInCents / denomination;
            if (count > 0)
            {
                if (denomination >= 100)
                {
                    textMessage += $"{count} x ${denomination / 100} bill(s)\n";
                }
                else
                {
                    textMessage += $"{count} x {denomination / 100.0:C} coin(s)\n";
                }

                amountInCents %= denomination;
            }
        }

        denomination = 25;
        {
            int count = amountInCents / denomination;
            if (count > 0)
            {
                if (denomination >= 100)
                {
                    textMessage += $"{count} x ${denomination / 100} bill(s)\n";
                }
                else
                {
                    textMessage += $"{count} x {denomination / 100.0:C} coin(s)\n";
                }

                amountInCents %= denomination;
            }
        }

        denomination = 10;
        {
            int count = amountInCents / denomination;
            if (count > 0)
            {
                if (denomination >= 100)
                {
                    textMessage += $"{count} x ${denomination / 100} bill(s)\n";
                }
                else
                {
                    textMessage += $"{count} x {denomination / 100.0:C} coin(s)\n";
                }

                amountInCents %= denomination;
            }
        }

        denomination = 5;
        {
            int count = amountInCents / denomination;
            if (count > 0)
            {
                if (denomination >= 100)
                {
                    textMessage += $"{count} x ${denomination / 100} bill(s)\n";
                }
                else
                {
                    textMessage += $"{count} x {denomination / 100.0:C} coin(s)\n";
                }

                amountInCents %= denomination;
            }
        }

        denomination = 1;
        {
            int count = amountInCents / denomination;
            if (count > 0)
            {
                if (denomination >= 100)
                {
                    textMessage += $"{count} x ${denomination / 100} bill(s)\n";
                }
                else
                {
                    textMessage += $"{count} x {denomination / 100.0:C} coin(s)\n";
                }

                amountInCents %= denomination;
            }
        }

        return textMessage;
    }
}
