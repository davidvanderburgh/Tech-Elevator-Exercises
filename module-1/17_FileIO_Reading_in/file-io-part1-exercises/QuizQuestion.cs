using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace file_io_part1_exercises
{
    public class QuizQuestion
    {
        public string Question { get; set; }
        public List<string> Answers { get; set; }
        public string CorrectAnswer { get; set; }
        public int CorrectAnswerNumber { get; set; }

        public QuizQuestion(string inputLine)
        {
            CorrectAnswerNumber = 0;
            Answers = new List<string>();
            InitializeQuestionsAndAnswers(inputLine);
        }

        private void InitializeQuestionsAndAnswers(string inputLine)
        {
            string[] sections = inputLine.Split('|');

            //find correct answer
            int correctAnswersFound = 0;
            for (int i = 0; i < sections.Length; i++)
            {
                if (sections[i].Contains('*'))
                {
                    CorrectAnswerNumber = i; //since answer indices starts at 1
                    correctAnswersFound++;

                    //remove asterisk from correct answer
                    sections[i] = sections[i].Replace("*", "");
                    CorrectAnswer = sections[i];
                }
            }

            //no '|' found
            if (sections.Length == 0)
            {
                throw new QuizQuestionException($"Error - Input line: \"{ inputLine }\" does not have any \'|\'");
            }
            //no asterisks found or asterisk on the question
            else if (CorrectAnswerNumber == 0)
            {
                throw new QuizQuestionException($"Error - Input line: \"{ inputLine }\" no \'*\' found on any answers");
            }
            //multiple asterisks found
            else if (correctAnswersFound != 1)
            {
                throw new QuizQuestionException($"Error - Input line: \"{ inputLine }\" wrong number of answers found");
            }
            else
            {
                //add question
                //add answers
                Question = sections[0];
                for (int i = 1; i < sections.Length; i++)
                {
                    Answers.Add(sections[i]);
                }
            }
        }
    }

    public class QuizQuestionException : Exception
    {
        public QuizQuestionException(string message) : base(message)
        {            
        }
    }
}
