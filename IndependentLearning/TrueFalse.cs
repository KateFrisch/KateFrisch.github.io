using System;

namespace TrueOrFalse
{
    class TrueOrFalse
    {
        static void Main(string[] args)
        {
            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            Tools.SetUpInputStream(entry);

            // Type your code below
            string[] questions = new string[] { "My name is Kate.", "I live in Saratoga.", "I like dogs." };
            bool[] answers = new bool[] { true, false, true };
            bool[] responses = new bool[questions.Length];
            if (questions.Length != answers.Length)
            {
                Console.WriteLine("Error: questions and answers are not the same amount");
            }

            int askingIndex = 0;
            foreach (string q in questions)
            {
                Console.WriteLine(q);
                Console.WriteLine("True or false?");

                string input = Console.ReadLine();
                bool inputBool;
                bool isBool = Boolean.TryParse(input, out inputBool);

                while (isBool == false)
                {
                    Console.WriteLine("Please respond with 'true' or 'false'.");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }
                Console.WriteLine();

                responses[askingIndex] = inputBool;
                askingIndex++;
            }
            Console.WriteLine(String.Join(", ", responses));
            int scoringIndex = 0;
            int score = 0;

            foreach (bool ans in answers)
            {
              bool response = responses[scoringIndex];
              Console.WriteLine($"{scoringIndex + 1}. Input:{response} | Answer: {ans}");

              if(response == ans){
                score++;
              }
              scoringIndex++;
            }

            Console.WriteLine($"You got {score} out of {questions.Length} correct!");
        }
    }
}
