using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


struct Teacher
{
    public string Name;
    public string Subject;
    public int Age;

    // Метод для отображения данных о преподавателе
    public void DisplayTeacherInfo()
    {
        Console.WriteLine($"Имя: {Name}");
        Console.WriteLine($"Предмет: {Subject}");
        Console.WriteLine($"Возраст: {Age} лет");
    }
}

namespace VGTUlab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            string input = Console.ReadLine();
            double x, y, z;
            x = Double.Parse(input);
            input = Console.ReadLine();
            y = Double.Parse(input);
            input = Console.ReadLine();
            z = Double.Parse(input);
            double a, b;
            a = (1 + y) * ((x + (y / (Math.Pow(x, 2) + 4))) / (Math.Pow(2.7, 2) + (1 / (Math.Pow(x, 2) + 4))));
            b = (1 + Math.Pow(Math.Cos(y - x), 3)) / ((Math.Pow(x, 2) / 2) + Math.Pow(Math.Sin(z), 2));
            Console.WriteLine(x + " " + y + " " + z);
            Console.WriteLine(a + " " + b);
            double x1 = 1, y1 = 1, x2 = 5, y2 = 4, x3 = 7, y3 = 1;
            double S, P;
            double a1, b1, c1;
            P = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)) + Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2)) + Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));
            S = Math.Sqrt(P / 2 * (P / 2 - Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2))) * (P / 2 - Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2))) * (P / 2 - Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2))));
            Console.WriteLine(S + " " + P);
            ThirdTask();
            FourthTask();
            Teacher teacher1;
            teacher1.Name = "Иван Иванов";
            teacher1.Subject = "Математика";
            teacher1.Age = 35;

            // Вызываем метод отображения данных
            Console.WriteLine("Данные о преподавателе:");
            teacher1.DisplayTeacherInfo();
        }
        static void ThirdTask()
        {
            Console.Write("Введите координату x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Введите координату y: ");
            double y = double.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Точка находится в первой четверти.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Точка находится во второй четверти.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Точка находится в третьей четверти.");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Точка находится в четвёртой четверти.");
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine("Точка лежит на оси Y.");
            }
            else if (x != 0 && y == 0)
            {
                Console.WriteLine("Точка лежит на оси X.");
            }
            else
            {
                Console.WriteLine("Точка лежит в начале координат.");
            }
        }
        static void FourthTask()
        {
            Console.Write("Введите значение n >> ");
            int n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                Console.Write("Введите значение a >> ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Введите значение b >> ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Введите значение c >> ");
                double c = double.Parse(Console.ReadLine());
                Console.Write("Введите значение x >> ");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine(a*Math.Pow(x,2) + b*x+ c);
            }
            else if (n == 2)
            {
                Console.Write("Введите значение a >> ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Введите значение b >> ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Введите значение x >> ");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine(a * Math.Pow(x, 3) + 3* b * x + Math.Pow(b, 3));
            }
            else if (n ==3)
            {
                Console.Write("Введите значение x >> ");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine(4 * Math.Pow(Math.Sin(x), 2) + Math.Pow(Math.Cos(x), 2));
            }
            else if (n == 4)
            {
                Console.Write("Введите значение x >> ");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Введите значение x >> ");
                double y = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Sqrt(Math.Abs(x-y) * Math.Pow(Math.Cos(x), 2)));
            }
            else if (n == 5)
            {
                Console.Write("Введите значение x >> ");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine(1.0 / Math.Pow(Math.Tan(x),2));
            }
            else
            {
                Console.WriteLine("Неправильно введён n.");
            }
        }
    }
}
