namespace Task_4
{
    public class Car
    {
        public const string CompanyName = "Subaru";
        private string _name;
        private string _color;
        private decimal _price;

        public Car()
        {

        }

        public Car(string name, string color, decimal price)
        {
            _name = name;
            _color = color;
            _price = price;
        }

        public string Color 
        {
            get => _color;
            set => _color = value;
        }
    }
}