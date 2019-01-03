using System.Collections.Generic;

namespace KnowledgeTesting
{
    partial class GAnswer
    {
        public GAnswer(Answer answer)
        {
            Text = answer.Text;
            IsCorrect = answer.IsCorrect;
        }

        public GAnswer()
        {

        }

        public Answer Create()
        {
            Answer answer = new Answer();
            answer.Text = Text;
            answer.IsCorrect = IsCorrect;
            return answer;
        }
    }
}