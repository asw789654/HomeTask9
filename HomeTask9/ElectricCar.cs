namespace Task1
{
    internal class ElectricCar : Car
    {
        private double _rangeOnOneCharge;
        private double _batteryCapacity;

        public ElectricCar(double weight = 1, double maxSpeed = 1, int doorsNumber = 1, double rangeOnOneCharge = 50, double batteryCapacity = 1) : base(weight, maxSpeed, doorsNumber, "Электричество")
        {
            RangeOnOneCharge = rangeOnOneCharge;
            BatteryCapacity = batteryCapacity;
        }

        public double RangeOnOneCharge
        {
            get
            {
                return _rangeOnOneCharge;
            }
            set
            {
                if (value > 0)
                {
                    _rangeOnOneCharge = value;
                }
                else
                {
                    _rangeOnOneCharge = 1;
                }
            }
        }

        public double BatteryCapacity
        {
            get
            {
                return _batteryCapacity;
            }
            set
            {
                if (value > 0)
                {
                    _batteryCapacity = value;
                }
                else
                {
                    _batteryCapacity = 1;
                }
            }
        }

        public new void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine(
                $"Заряд автомобиля: {_batteryCapacity}{Environment.NewLine}" +
                $"Дальность хода на одном заряде: {_rangeOnOneCharge}{Environment.NewLine}");
        }
    }
}
