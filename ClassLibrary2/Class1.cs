namespace ClassLibrary2
{
    public class Car
    {
        string _make;
        string _model;
        decimal _price;
        bool _rented;

        public bool Available
        {
            set
            {
                _rented = value;
            }
            get
            {
                return !_rented;
            }
        }
        public Car(string make, string model,decimal price,bool rented)
        {
            _make = make;
            _model = model;
            _price = price;
            _rented = rented;
        }

        public bool Rent()
        {
            if(!_rented)
            {
                _rented=true;
                Console.WriteLine("Car Rented Successfully");
                return true;
            }
            else
            {
                Console.WriteLine("Car is already rented");
                return false;
            }
        }

        public bool Return()
        {
            if(_rented)
            {
                _rented = false;
                Console.WriteLine("Car Returned");
                return true;
            }
            else
            {
                Console.WriteLine("Error, Car was not rented");
                return false;
            }
        }

        public void PrintInfo()
        {
            string availabiity = this._rented ?"Rented": "Available";
            Console.WriteLine($"{_make} {_model} (Rental price: {_price}/day) - {availabiity}");
        }
    }
}
