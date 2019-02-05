using System;
using System.IO;
using System.Collections.Generic;

namespace file_io_part1_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read in the questions
            Console.WriteLine("Enter the fully qualified name of the file to read in for quiz questions:");
            string filePathAndName = Console.ReadLine();

            List<QuizQuestion> questions = new List<QuizQuestion>();

            try
            {
                using (StreamReader sr = new StreamReader(filePathAndName))
                {
                    while (!sr.EndOfStream)
                    {
                        try
                        {
                            questions.Add(new QuizQuestion(sr.ReadLine()));
                        }
                        catch (QuizQuestionException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error! <{filePathAndName}> reading error");
            }

            int correctAnsweredCount = 0;

            //Display the questions to the user
            foreach (QuizQuestion quizQuestion in questions)
            {
                Console.WriteLine(quizQuestion.Question);

                for (int i = 0; i < quizQuestion.Answers.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {quizQuestion.Answers[i]}");
                }

                //Ask for the correct answer
                Console.WriteLine("\nYour Answer: ");
                int.TryParse(Console.ReadLine(), out int answeredNumber);
                if (answeredNumber == quizQuestion.CorrectAnswerNumber)
                {
                    Console.WriteLine("RIGHT!");
                    correctAnsweredCount++;
                }
                else
                {
                    Console.WriteLine($"WRONG!");
                }
            }

            //Sum the correct answers and show the total
            Console.WriteLine($"You got {correctAnsweredCount} answer(s) correct out of the {questions.Count} asked.");
            Console.ReadLine();
        }
    }
}
