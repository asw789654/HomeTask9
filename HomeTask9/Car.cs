namespace Task1
{
    internal class Car : Vehicle
    {
        protected int _doorsNumber;
        protected string _fuelType;

        public Car(double weight = 1, double maxSpeed = 1, int doorsNumber = 1, string fuelType = "дизель") : base(weight, maxSpeed)
        {
            DoorsNumber = doorsNumber;
            FuelType = fuelType;
        }

        public int DoorsNumber
        {
            get
            {
                return _doorsNumber;
            }
            set
            {
                if (value > 0)
                {
                    _doorsNumber = value;
                }
                else
                {
                    _doorsNumber = 1;
                }
            }
        }

        public string FuelType
        {
            get
            {
                return _fuelType;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    _fuelType = "дизельное";
                }
                else
                {
                    _fuelType = value;
                }
            }
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine(
                $"Тип топлива: {_fuelType}{Environment.NewLine}" +
                $"Количество дверей: {_doorsNumber}");
        }
    }
}
