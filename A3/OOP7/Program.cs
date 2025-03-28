using System;

namespace ColorBallDemo
{
    // Color class
    public class Color
    {
        private int _red;
        private int _green;
        private int _blue;
        private int _alpha;

        public Color(int red, int green, int blue, int alpha)
        {
            _red = red;
            _green = green;
            _blue = blue;
            _alpha = alpha;
        }

        public Color(int red, int green, int blue) : this(red, green, blue, 255) { }

        public int Red
        {
            get { return _red; }
            set { _red = value; }
        }

        public int Green
        {
            get { return _green; }
            set { _green = value; }
        }

        public int Blue
        {
            get { return _blue; }
            set { _blue = value; }
        }

        public int Alpha
        {
            get { return _alpha; }
            set { _alpha = value; }
        }

        public int GetGrayscale()
        {
            return (_red + _green + _blue) / 3;
        }
    }

    // Ball class
    public class Ball
    {
        private int _size;
        private Color _color;
        private int _throwCount;

        public Ball(int size, Color color)
        {
            _size = size;
            _color = color;
            _throwCount = 0;
        }

        public void Pop()
        {
            _size = 0;
        }

        public void Throw()
        {
            if (_size > 0)
            {
                _throwCount++;
            }
        }

        public int GetThrowCount()
        {
            return _throwCount;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Color redColor = new Color(255, 0, 0);
            Color greenColor = new Color(0, 255, 0);
            Color blueColor = new Color(0, 0, 255);

            Ball redBall = new Ball(10, redColor);
            Ball greenBall = new Ball(15, greenColor);
            Ball blueBall = new Ball(20, blueColor);

            redBall.Throw();
            redBall.Throw();
            greenBall.Throw();
            blueBall.Throw();
            blueBall.Throw();
            blueBall.Throw();

            // Pop the green ball
            greenBall.Pop();

            // Try throwing the green ball again
            greenBall.Throw();

            Console.WriteLine($"Red ball throw count: {redBall.GetThrowCount()}");
            Console.WriteLine($"Green ball throw count: {greenBall.GetThrowCount()}");
            Console.WriteLine($"Blue ball throw count: {blueBall.GetThrowCount()}");

            Console.WriteLine($"Red ball color grayscale value: {redColor.GetGrayscale()}");
        }
    }
}