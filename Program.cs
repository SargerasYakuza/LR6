using System;

namespace LR6
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================Тест================");

            Test testik = new Test();

            ((ITest)testik).ToSurvivale();

            testik.Study();

            testik.ToSurvivale();

            testik.GetSurvivale();

            testik.ToSurvivale();

            testik.GetSurvivale();

            testik.ExSurvival(8);
            

            if (testik is Survivale)

            {

                Console.WriteLine($"{testik} is Survivale");

            }

            Console.WriteLine("-----------Экзамен-------------");

            Exams Exams = new Exams("Math");

            IQuestions Exams_2 = Exams;

            Exams_2.PullQuestion();

            Exams_2.AnswerQuestion();

            Exams.ToSurvivale();

            Exams.GetSurvivale();

            Exams.ExSurvival(7);

            Console.WriteLine("-----------Выпускной экзамен-------------");

            FinallyExams FinEx = new FinallyExams();

            FinEx.ToSurvivale();

            FinEx.GetSurvivale();

            FinEx.ToSurvivale();

            FinEx.GetSurvivale();

            FinEx.ToSurvivale();

            FinEx.GetSurvivale();

            FinEx.GetFinExamsInfo();

            FinEx.ExSurvival(6);

            Printer printer = new Printer();

            const int n = 3;
            Survivale[] surv1 = new Survivale[n] { testik, FinEx, Exams };
            printer.iAmPrinting(surv1, n);

            


            bool i = true;
            while (i)
            {

                Console.Clear();

                Sessiya two = new Sessiya();
                while (i)
                {

                    Console.WriteLine("  Меню");
                    Console.WriteLine(" 1 - Вывести");
                    Console.WriteLine(" 2 - Добавить");
                    Console.WriteLine(" 3 - Удалить");
                    Console.WriteLine(" 4 - Поиск");
                    Console.WriteLine(" 5 - Кол-во испытаний");
                    Console.WriteLine(" 0 - Выйти");

                    Console.Write("\nВаш выбор = ");
                    int switch_on = int.Parse(Console.ReadLine());

                    Console.Clear();

                    switch (switch_on)
                    {
                        case 1:
                            two.Out();
                            break;
                        case 2:
                            two.Add();
                            break;
                        case 3:
                            two.Remove();
                            break;
                        case 4:
                            two = SessiyaController.Search(two);
                            break;
                        case 5:
                            two = SessiyaController.Kolvo(two);
                            break;

                        case 0:
                            i = false;
                            break;
                        default: break;
                    }


                }

            }





            Console.ReadKey();



        }
    }
}
