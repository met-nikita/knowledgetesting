namespace KnowledgeTesting
{
    public class Answer
    {
        string _text;
        bool _isCorrect;

        public string Text { get => _text; set => _text = value; }
        public bool IsCorrect { get => _isCorrect; set => _isCorrect = value; }

        public override string ToString()
        {
            return _text;
        }
    }
}
