using System;
using System.Linq;

namespace PracticalWork
{
    interface ITask
    {
        void Execute();
    }

    // Завдання 1
    class Task1 : ITask
    {
        public void Execute()
        {
            int number = 5;
            int[] numbers = { 3, 11, 8 };
            int lowerBound = 1;
            int upperBound = 10 + number;

            var result = numbers.Where(n => n >= lowerBound && n <= upperBound);

            Console.WriteLine("Числа в інтервалі [" + lowerBound + ", " + upperBound + "]: " + string.Join(", ", result));
        }
    }

    // Завдання 2
    class Task2 : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Введіть три сторони трикутника:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                double perimeter = a + b + c;
                double semiPerimeter = perimeter / 2;
                double area = Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));

                Console.WriteLine($"Периметр трикутника: {perimeter}");
                Console.WriteLine($"Площа трикутника: {area}");

                if (a == b && b == c)
                    Console.WriteLine("Трикутник рівносторонній.");
                else if (a == b || b == c || a == c)
                    Console.WriteLine("Трикутник рівнобедрений.");
                else
                    Console.WriteLine("Трикутник різносторонній.");
            }
            else
            {
                Console.WriteLine("Трикутник з такими сторонами не існує.");
            }
        }
    }

    // Завдання 3
    class Task3 : ITask
    {
        public void Execute()
        {
            int number = 5;
            int length = 10 + number;
            int[] array = new int[length];
            Random rand = new Random();

            for (int i = 0; i < length; i++)
                array[i] = rand.Next(-50, 50);

            int min = array.Min();
            int max = array.Max();

            Console.WriteLine("Масив: " + string.Join(", ", array));
            Console.WriteLine($"Мінімальне значення: {min}, Максимальне значення: {max}");
        }
    }

    // Завдання 4
    class Task4 : ITask
    {
        public void Execute()
        {
            int number = 5; // Остання цифра порядкового номеру у списку групи
            int length = 10 + number;
            int[] array = new int[length];
            Random rand = new Random();

            for (int i = 0; i < length; i++)
                array[i] = rand.Next(-50, 50);

            Console.WriteLine("Введіть число M:");
            int M = int.Parse(Console.ReadLine());

            int[] filteredArray = array.Where(x => Math.Abs(x) > M).ToArray();

            Console.WriteLine("Масив X: " + string.Join(", ", array));
            Console.WriteLine("Число M: " + M);
            Console.WriteLine("Масив Y: " + string.Join(", ", filteredArray));
        }
    }
    class TaskController
    {
        private readonly ITask[] tasks;

        public TaskController(ITask[] tasks)
        {
            this.tasks = tasks;
        }

        public void RunAllTasks()
        {
            foreach (var task in tasks)
            {
                Console.WriteLine("\nВиконання задачі:");
                task.Execute();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ITask[] tasks = { new Task1(), new Task2(), new Task3(), new Task4() };
            TaskController controller = new TaskController(tasks);

            controller.RunAllTasks();
        }
    }
}
