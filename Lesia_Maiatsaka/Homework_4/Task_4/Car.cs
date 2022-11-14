namespace Task_4
{
    public class Car
    {
        public const string CompanyName = "Subaru";
        private string _name;
        private CarColors _color;
        private double _price;

        public Car()
        {

        }

        public Car(string name, CarColors color, double price)
        {
            _name = name;
            _color = color;
            _price = price;
        }

        public CarColors Color 
        {
            get => _color;
        }

        public CarColors CarColorChange(string color) 
        {
            CarColors newColor;
            var success =  Enum.TryParse(color, out newColor);
            if (success)
            {
                _color = newColor;
            }

            var newPrice = _color switch
            {
                CarColors.White => ChangePrice(0.1),
                CarColors.Black => ChangePrice(0.5),
                CarColors.Red => ChangePrice(1.2),
                CarColors.Green => ChangePrice(2.3),
                CarColors.Blue => ChangePrice(0.002),
                CarColors.Yellow => ChangePrice(0.7),
                CarColors.Grey => ChangePrice(0.2),
                _ => throw new NotImplementedException(),
            };

            return _color;
        }

        public string Print() => $"This is a {_name}, its color is {_color} and its price is {_price}";

        public double ChangePrice(double percentage) => _price *= percentage;
        public static bool operator == (Car car1, Car car2)
        {
            if ((object)car1 == null)
                return (object)car2 == null;

            return car1._name == car2._name && car1._price == car2._price;
        }
        public static bool operator != (Car car1, Car car2)
        {
            if ((object)car1 == null)
                return (object)car2 == null;

            return car1._name != car2._name || car1._price != car2._price;
        }
        public override string ToString()
        {
            return Print();
        }
    }
}