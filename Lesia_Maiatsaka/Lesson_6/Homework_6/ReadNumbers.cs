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
        }

        public int ReadNumber(int number) 
        {
            if (number < _start || number > _end || number < _current)
            {
                throw new Exception("Number is invalid");
            }
            return _current = number;
        }
    }
}
