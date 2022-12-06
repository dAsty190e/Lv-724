namespace Homework_6
{
    public class ReadNumbers
    {
        private int _start;
        private int _end;
        private int _current;

        public ReadNumbers(int start, int end)
        {
            _start = start;
            _end = end;
            _current = start;
            ValidNumbers = new List<int>();
        }

        public List<int> ValidNumbers { get; set; }

        public int ReadNumber(int number) 
        {
            if (number < _start || number > _end || number <= _current)
            {
                throw new Exception("Number is invalid");
            }
            ValidNumbers.Add(number);
            return _current = number;
        }
        public bool Complete(int number) 
        {
            return number == _end;
        }
    }
}
