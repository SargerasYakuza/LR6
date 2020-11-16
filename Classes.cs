using System;
using System.Collections.Generic;
using System.Text;

namespace LR6
{
    class Printer
    {
        public void iAmPrinting(Survivale[] surv, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Тип объекта = " + surv[i].ToString());

            }


        }

    }

    public abstract class Survivale
    {
        protected int NumOfSurv = 0;
        protected int NumOfFinExams = 0;
        public override string ToString() => "Survivale";
        public Survivale() { }
        public virtual void ExSurvival(int MarkSurvival)
        {
            Console.WriteLine($"Вы получили общую оценку за испытание: {MarkSurvival}");

        }
        public abstract void ToSurvivale();
        public void GetSurvivale() => Console.WriteLine($"Всего {NumOfSurv} испытаний вида {ToString()}");
        public void GetFinExamsInfo() => Console.WriteLine($"Пройдено {NumOfFinExams} выпускных экзаменов. ");

    }

    sealed class HardSurvivale : Survivale
    {

        public override string ToString() => "Survivale";

        public override void ToSurvivale() => Console.WriteLine("Вы прошли еще одно испытание ", NumOfSurv += 1);



    }

    class FinallyExams : Survivale
    {

        public override string ToString() => "FinallyExam";

        public override void ToSurvivale() => Console.WriteLine("Вы сдали выпускной экзамен", NumOfSurv += 1, NumOfFinExams += 1);


        public override bool Equals(object obj)

        {

            if (obj.GetType() != GetType())
                return false;
            FinallyExams other = obj as FinallyExams;
            return (NumOfSurv == other.NumOfSurv);

        }
        public override int GetHashCode()
        {
            return DateTime.Now.Millisecond;

        }

    }

    class Exams : FinallyExams, IQuestions
    {
        public string Lesson { get; set; }
        public Exams(string lesson)
        {
            Lesson = lesson;
            Console.WriteLine(Lesson);
        }
        public override string ToString() => "Exams" + "\n" + Lesson;

        public override void ToSurvivale() => Console.WriteLine("Вы сдали экзамен", NumOfSurv += 1);
        public void PullQuestion() => Console.WriteLine("Вопрос: Самая высокая точка на земле?");
        public void AnswerQuestion() => Console.WriteLine("Ответ: Эверест.");

    }

    class Test : FinallyExams, ITest
    {

        
        public override string ToString() => "Test";
        public override void ToSurvivale() => Console.WriteLine("Вы прошли испытание", NumOfSurv += 1);
        void ITest.ToSurvivale() => Console.WriteLine("Вы сдали тест!");
        public void PullTest() => Console.WriteLine("Тест по географии");
        public void PullQuestion() => Console.WriteLine("Вопросы теста: Самая высокая точка на земле? \n Самый высокий водопад? \n Самая длинная река?\n У какой реки течение направлено с юга на север?\n ");
        public void AnswerQuestion() => Console.WriteLine("Ответ: Эверест, Анхель, Амазонка, Нил.");

        public void Study()
        {
            Console.WriteLine("-----------Структура-------------");
            Console.WriteLine("Введите имя студента");
            string Name1 = Console.ReadLine();
            Console.WriteLine("Введите возраст студента");
            int age1 = int.Parse(Console.ReadLine());
            Student study = new Student(Name1, age1);
            study.info();
        }

    }


}



