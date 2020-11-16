using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LR6
{
    public class Sessiya
    {
        public List<Survivale> survivale = new List<Survivale>();
        public int Exam { get; set; }
        public int Zachet { get; set; }

        public Sessiya(int exam, int zachet)
        {
            Exam = exam;
            Zachet = zachet;
        }
        
        

        FinallyExams finex = new FinallyExams();
        Exams ex = new Exams("Math");
        Test test = new Test();


        public List<Survivale> Survivale { get; set; }

        public void Out()
        {
            Console.Clear();
            Console.WriteLine("Вывод списка");
            Console.WriteLine("-\t-\t-");

            if (Exam == 0 && Zachet == 0)
            {
                Console.WriteLine("Список пуст");
                return;
            }

            Console.WriteLine("Элементы списка:");
            foreach (var i in survivale)
            {
                Console.WriteLine(" " + i);
            }
            Console.ReadLine();
            Console.Clear();
        }

        public void Add()
        {

            int switch_on;

            Console.WriteLine("Экзаменов = " + Exam);
            Console.WriteLine("Зачетов  = " + Zachet);
            Console.WriteLine("-\t-\t-");


            Console.WriteLine("Типы испытаний:");
            Console.WriteLine(" 1 - Выпускной экзамен(экзамен)");
            Console.WriteLine(" 2 - Экзамен(экзамен)");
            Console.WriteLine(" 3 - Тест(зачет)");

            Console.Write("Выберите тип испытания: ");
            switch_on = int.Parse(Console.ReadLine());


            switch (switch_on)
            {
                case 1:
                    survivale.Add(finex);
                    Exam++;
                    break;
                case 2:
                    survivale.Add(ex);
                    Exam++;
                    break;
                case 3:
                    survivale.Add(test);
                    Zachet++;
                    break;
                default:
                    break;
            }
        }

        public void Remove()
        {
            Console.Clear();
            Console.WriteLine("Удаление элемента");
            Console.WriteLine("-\t-\t-");

            Console.WriteLine("Всего элементов = " + survivale.Count);
            Console.WriteLine("Введите номер элемента который вы хотите удалить");

            int numb = int.Parse(Console.ReadLine());
            survivale.RemoveAt(numb - 1);

        }

        public Sessiya()
        {
            bool end = false;
            int ch;


            while (!end)
            {
                Console.WriteLine("Типы испытаний:");
                Console.WriteLine(" 1 - Выпускной экзамен(экзамен)");
                Console.WriteLine(" 2 - Экзамен(экзамен)");
                Console.WriteLine(" 3 - Тест(зачет)");

                Console.Write("Выберите тип испытания: ");
                int switch_on = int.Parse(Console.ReadLine());
                int i = 0;
                switch (switch_on)
                {
                    case 1:
                        survivale.Add(finex);
                        Exam++;
                        Console.WriteLine("Продолжать цикл? 0 - да, 1 - нет");
                        ch = int.Parse(Console.ReadLine());
                        if (ch == 0)
                            end = false;
                        else
                            end = true;
                        break;
                    case 2:
                        survivale.Add(ex);
                        Exam++;
                        Console.WriteLine("По какому предмету экзамен?");
                        ex.Lesson = Console.ReadLine();
                        Console.WriteLine("Продолжать цикл? 0 - да, 1 - нет");
                        ch = int.Parse(Console.ReadLine());
                        if (ch == 0)
                            end = false;
                        else
                            end = true;
                        break;
                    case 3:
                        survivale.Add(test);
                        Zachet++;
                        Console.WriteLine("Продолжать цикл? 0 - да, 1 - нет");
                        ch = int.Parse(Console.ReadLine());
                        if (ch == 0)
                            end = false;
                        else
                            end = true;
                        break;
                    default:
                        continue;
                }
                Console.WriteLine("Колличество зачетов {0} экзаменов {1}", Zachet, Exam);
                Console.WriteLine("-\t-\t-");
            }
        }

       

    }
    public static class SessiyaController
    {


        public static Sessiya Search(Sessiya sessiya)
        {
            Console.Clear();
            Console.WriteLine("Поиск по заданному предмету");
            Console.WriteLine("-\t-\t-");
            if (sessiya.survivale.Count == 0)
            {
                Console.WriteLine("Список пуст");
                return sessiya;
            }
            Console.WriteLine("Предмет поиска: ");
            string les = Console.ReadLine();
            foreach (Exams i in sessiya.survivale)
            {
                if (les == i.Lesson)
                {
                    Console.WriteLine(i);
                }
            }

            return sessiya;
        }

        public static Sessiya Kolvo(Sessiya sessiya)
        {
            Console.WriteLine($"Экзаменов всего: {sessiya.Exam}");
            Console.WriteLine($"Зачетов всего: {sessiya.Zachet}");
            Console.WriteLine($"Всего испытаний: {sessiya.Zachet + sessiya.Exam}");

            return sessiya;
        }
    }

}
