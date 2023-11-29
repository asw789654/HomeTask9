namespace Task1
{
    internal class Truck : Vehicle
    {
        private double _liftingСapacity;
        private double _height;
        public Truck(double weight = 1, double maxSpeed = 1, double liftingСapacity = 1, double height = 1) : base(weight, maxSpeed)
        {
            LiftingСapacity = liftingСapacity;
            Height = height;
        }

        public double LiftingСapacity
        {
            get
            {
                return _liftingСapacity;
            }
            set
            {
                if (value > 0)
                {
                    _liftingСapacity = value;
                }
                else
                {
                    _liftingСapacity = 1;
                }
            }
        }

        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value > 0)
                {
                    _height = value;
                }
                else
                {
                    _height = 1;
                }
            }
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine(
                $"Высота: {_height}{Environment.NewLine}" +
                $"Грузоподъёмность: {_liftingСapacity}{Environment.NewLine}");
        }
    }
}
