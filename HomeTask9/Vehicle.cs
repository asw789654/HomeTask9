namespace Task1
{
    internal abstract class Vehicle
    {
        protected double _weight;
        protected double _maxSpeed;

        protected Vehicle(double weight = 1, double maxSpeed = 1)
        {
            Weight = weight;
            MaxSpeed = maxSpeed;
        }

        public double Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                if (value > 0)
                {
                    _weight = value;
                }
                else
                {
                    _weight = 1;
                }
            }
        }

        public double MaxSpeed
        {
            get
            {
                return _maxSpeed;
            }
            set
            {
                if (value > 0)
                {
                    _maxSpeed = value;
                }
                else
                {
                    _maxSpeed = 1;
                }
            }
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Максимальная скорость: {_maxSpeed}{Environment.NewLine}Масса: {_weight}");
        }

    }
}
