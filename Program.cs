namespace ExamRepoStrigina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(1.0, 2.0, 3.0);
            Vector v2 = new Vector(4.0, 5.0, 6.0);

            Vector sum = v1.Add(v2);
            double dotProduct = v1.DotProduct(v2);
            double length = v1.Length();

            Console.WriteLine($"Сумма векторов: {sum}");
            Console.WriteLine($"Скалярное произведение векторов: {dotProduct}");
            Console.WriteLine($"Длина вектора: {length}");

            v1.Print();
        }
    }


    class Vector
    {
        private double x, y, z; // Координаты конца вектора

        // Конструкторы
        public Vector() : this(0, 0, 0) { }
        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        // Методы
        public Vector Add(Vector other)
        {
            return new Vector(x + other.x, y + other.y, z + other.z);
        }
        //скалярное
        public double DotProduct(Vector other)
        {
            return x * other.x + y * other.y + z * other.z;
        }

        public double Length()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }
        public override string ToString()
        {
            return $"({x}, {y}, {z})";
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }

}