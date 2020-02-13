using System;

namespace GeniyIdiotConsoleApp
{
    class Program
    {
        static string[] GetQuestions(int countQuestions)
        {
            // добавил комментарий длдя теста
            string[] questions = new string[countQuestions];
            questions[0] = "Сколько будет два плюс два  умноженное на два?";
            questions[1] = "Бревно нужно распилить на 10  частей, сколько надо сделать  распилов?";
            questions[2] = "На двух руках 10 пальцев. Сколько пальцев на 5 руках?";
            questions[3] = "Укол делают каждые полчаса,  сколько нужно минут для трех  уколов?";
            questions[4] = "Пять свечей горело, две  потухли. Сколько свечей  осталось?";

            return questions;
        }

        static int[] GetAnswers(int countQuestions)
        {
            int[] answers = new int[countQuestions];
            answers[0] = 6;
            answers[1] = 9;
            answers[2] = 25;
            answers[3] = 60;
            answers[4] = 2;

            return answers;
        }
        static void Main(string[] args)
        {
            int countQuestions = 5;
            string[] questions = GetQuestions(countQuestions);

            int[] answers = GetAnswers(countQuestions);

            int countRightAnswer = 0;

            for (int i = 0; i < countQuestions; i++)
            {
                Console.WriteLine("Вопрос №" + (i + 1));
                int randomQuestionIndex = GetRandomQuestionIndex(countQuestions);
                Console.WriteLine(questions[randomQuestionIndex]);

                int userAnswer = Convert.ToInt32(Console.ReadLine());

                int rightAnswer = answers[randomQuestionIndex];

                if (userAnswer == rightAnswer)
                {
                    countRightAnswer++;
                }
            }

            string[] diagnoses = new string[6];
            diagnoses[0] = "Идиот";
            diagnoses[1] = "Кретин";
            diagnoses[2] = "Дурак";
            diagnoses[3] = "Нормальный";
            diagnoses[4] = "Талант";
            diagnoses[5] = "Гений";
            Console.WriteLine("Ваш диагноз:" + diagnoses[countRightAnswer]);

            Console.ReadKey();
        }

        static int GetRandomQuestionIndex(int countQuestions)
        {
            Random random = new Random();
            return random.Next(0, countQuestions);
        }
    }
}
