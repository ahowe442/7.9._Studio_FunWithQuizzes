using System;
using System.Collections.Generic;

namespace _7._9._Studio_FunWithQuizzes
{
    public class Quiz
    {
        public void RunQuiz()
        {
            //loop through all questions
            //and display each question
            //Display the answer choices for each question.
            //User selects answer

            //Show correct answer


        }
        public void DisplayQuest()
        {

        }
        public void DisplayAnswerChoices()
        {

        }
    }

    public class Question
    {
        private string Quest { get; set; }


    }

    public class MultipleChoice : Question
    {
        Dictionary<string, bool> answers =
                       new Dictionary<string, bool>();
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_7._9._Studio_FunWithQuizzes");
            Console.WriteLine($"Welcome to the Quiz. Type \"Start\" to begin the quiz. ");
        }
    }
}