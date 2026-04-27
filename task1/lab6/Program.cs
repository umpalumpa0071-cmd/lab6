internal class Program
{
    private static int ReadMark(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("ошибка: пустой ввод");
                continue;
            }

            if (int.TryParse(input, out int result))
            {
                if (result >= 2 && result <= 5)
                    return result;

                Console.WriteLine("ошибка: оценка должна быть от 2 до 5");
                continue;
            }

            Console.WriteLine("ошибка: введите число");
        }
    }

    private static void Main()
    {
        Console.WriteLine("=== тестирование ===\n");

        int m1 = ReadMark("оценка 1: ");
        int m2 = ReadMark("оценка 2: ");
        int m3 = ReadMark("оценка 3: ");

        Console.Write("комментарий: ");
        string comment = Console.ReadLine();

        StudentMarks obj = new StudentMarks(m1, m2, m3, comment);

        Console.WriteLine($"объект: {obj}");
        Console.WriteLine($"копия: {new StudentMarks(obj)}");
        Console.WriteLine($"ср. балл: {obj.GetAverage():F2}");

        obj.AddExclamations();
        Console.WriteLine($"после !!!: {obj}");

        Console.WriteLine($"сдал: {(obj.IsPassed() ? "да" : "нет")}");
        Console.WriteLine($"макс. оценка: {obj.GetMaxMark()}");

        Console.WriteLine("\nнажмите любую клавишу...");
        Console.ReadKey();
    }
}
