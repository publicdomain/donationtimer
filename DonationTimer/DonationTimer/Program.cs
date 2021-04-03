// <copyright file="Program.cs" company="PUblicDomain.com">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>

namespace DonationTimer
{
    // Directives
    using System;

    /// <summary>
    /// Main class.
    /// </summary>
    class MainClass
    {
        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        public static void Main(string[] args)
        {
            // Declare valid wait time flag
            bool isValidWaitTime = false;

            // Declare wait time 
            string waitTime = string.Empty;

            // Declare hour and minutes
            int hour = 0, minutes = 0;

            // Get valid waittime from user
            do
            {
                // Ask for wait time
                Console.WriteLine("Please enter wait time [hmm]: ");

                // Set wait time
                waitTime = Console.ReadLine();

                // Check for valid input
                if (waitTime.Length == 3 && int.TryParse(waitTime, out int result))
                {
                    // Set hour
                    hour = int.Parse(waitTime.Substring(0, 1));

                    // Set minutes
                    minutes = int.Parse(waitTime.Substring(1, 2));

                    // Validate minutes
                    if (minutes < 60)
                    {
                        // Toggle flag
                        isValidWaitTime = true;
                    }
                }

            } while (!isValidWaitTime);

            // Print sleep time
            Console.WriteLine($"{hour} hour{(hour > 1 ? "s" : string.Empty)} {minutes} minute{(minutes > 1 ? "s" : string.Empty)}...");
        }
    }
}
