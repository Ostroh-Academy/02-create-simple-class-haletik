using System;

namespace CircleApp
{
    class Circle
    {
        // Приватні поля
        private double _radius;
        private double _centerX;
        private double _centerY;

        // Властивості з методами доступу
        public double Radius
        {
            get { return _radius; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Радіус повинен бути більше нуля.");
                _radius = value;
            }
        }

        public double CenterX
        {
            get { return _centerX; }
            set { _centerX = value; }
        }

        public double CenterY
        {
            get { return _centerY; }
            set { _centerY = value; }
        }

        // Конструктор
        public Circle(double radius, double centerX, double centerY)
        {
            Radius = radius;
            CenterX = centerX;
            CenterY = centerY;
        }

        // Метод для обчислення площі
        public double CalculateArea()
        {
            return Math.PI * _radius * _radius;
        }

        // Метод для введення даних
        public static Circle InputCircleData()
        {
            Console.Write("Введіть радіус кола: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть координату X центру кола: ");
            double centerX = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть координату Y центру кола: ");
            double centerY = Convert.ToDouble(Console.ReadLine());

            return new Circle(radius, centerX, centerY);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Введення даних
                Circle circle = Circle.InputCircleData();

                // Обчислення площі
                double area = circle.CalculateArea();

                // Виведення результату
                Console.WriteLine($"Площа кола з радіусом {circle.Radius} та центром ({circle.CenterX}, {circle.CenterY}) дорівнює {area}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
