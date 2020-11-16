using System;
using System.Collections.Generic;
using System.Text;

namespace LR6
{
        interface ITest : IQuestions
        {
            void PullTest();
            void ToSurvivale();
        }
        interface IQuestions
        {
            void PullQuestion();
            void AnswerQuestion();
        }
}
