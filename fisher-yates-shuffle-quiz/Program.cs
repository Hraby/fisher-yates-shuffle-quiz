using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace fisher_yates
{
    internal class Program
    {
        public static Random rnd = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Quiz using Fisher-Yates shuffle algorithm\n");

            //Length of the quiz questions
            int quizLength = 5;

            //Shuffle quiz questions
            int[] shuffle = Shuffle(quizLength);

            //Quiz intialiaze
            for (int i = 0; i < quizLength; i++)
            {
                Console.Clear();
                Console.WriteLine("Quiz using Fisher-Yates shuffle algorithm\n");
                Console.WriteLine("Question {0}/{1}\n", i+1, quizLength);

                Questions(shuffle[i]);

                if (i == quizLength - 1)
                {
                    Console.WriteLine("This is THE END");
                }
            }

            Console.ReadKey();
        }

        // Fisher-Yates shuffle algorithm
        public static int[] Shuffle(int quizLength)
        {
            int[] list = new int[quizLength];
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = i;
            }

            for (int i = list.Length-1; i >= 0; i--)
            {
                int j = rnd.Next(0, i);
                int temp = list[j];
                list[j] = list[i];
                list[i] = temp;
            }
            return list;
        }

        // Quiz questions
        public static void Questions(int choice)
        {
            switch (choice)
            {
                case 0:
                    Console.WriteLine("Nejvyšší hora světa?");
                    Console.WriteLine("a, Sněžka");
                    Console.WriteLine("b, Mount Everest");
                    Console.WriteLine("c, Mont Blanc");
                    Console.WriteLine("---\nChoose a, b or c");

                    char input = InputValidation();

                    AnswerValidation(input, 'b');

                    break;
                case 1:
                    Console.WriteLine("Nejvyšší hora ČR?");
                    Console.WriteLine("a, Mount Everest");
                    Console.WriteLine("b, Králický Sněžník");
                    Console.WriteLine("c, Sněžka");
                    Console.WriteLine("---\nChoose a, b or c");

                    input = InputValidation();

                    AnswerValidation(input, 'c');

                    break;
                case 2:
                    Console.WriteLine("Nejdelší řeka světa?");
                    Console.WriteLine("a, Amazonka");
                    Console.WriteLine("b, Dřevnice");
                    Console.WriteLine("c, Nil");
                    Console.WriteLine("---\nChoose a, b or c");

                    input = InputValidation();

                    AnswerValidation(input, 'a');

                    break;
                case 3:
                    Console.WriteLine("Nejmenší stát Evropy?");
                    Console.WriteLine("a, Vatikán");
                    Console.WriteLine("b, Česko");
                    Console.WriteLine("c, Monako");

                    Console.WriteLine("---\nChoose a, b or c");

                    input = InputValidation();

                    AnswerValidation(input, 'a');

                    break;
                case 4:
                    Console.WriteLine("Hlavní město ČR?");
                    Console.WriteLine("Brno");
                    Console.WriteLine("Ústí nad Labem");
                    Console.WriteLine("Praha");

                    Console.WriteLine("---\nChoose a, b or c");

                    input = InputValidation();

                    AnswerValidation(input, 'c');

                    break;
            }
        }

        // Answer validation
        public static void AnswerValidation(char input, char correct)
        {
            if (char.ToLower(input) == correct)
            {
                Console.WriteLine("\nCorrect answer\nPress ENTER...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\nWrong answer\nPress ENTER...");
                Console.ReadLine();
            }
        }

        // User answer input validation
        public static char InputValidation()
        {
            char input = Console.ReadLine()[0];
            while (input != 'a' && input != 'b' && input != 'c')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Choose a, b, or c:");
                Console.ResetColor();
                input = Console.ReadLine()[0];
            }
            return input;
        }
    }
}
