internal class Program
{
    private static uint ReadUInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (uint.TryParse(input, out uint result))
                return result;

            Console.WriteLine("ошибка: введите неотрицательное число");
        }
    }

    private static void Main()
    {
        Console.WriteLine("=== задание 2: базовые методы ===\n");

        uint r = ReadUInt("рубли: ");
        uint k = ReadUInt("копейки: ");

        Money m = new Money(r, (byte)k);

        Console.WriteLine($"объект: {m}");
        Console.WriteLine($"копия: {new Money(m)}");

        uint add = ReadUInt("добавить копеек: ");
        Money m2 = m.AddKopeks(add);

        Console.WriteLine($"после добавления: {m2}");

        Console.WriteLine("\n=== задание 3: перегрузка операторов ===\n");

        Console.WriteLine($"++: {++m}");
        Console.WriteLine($"--: {--m}");

        Console.WriteLine($"m + 50: {m + 50}");
        Console.WriteLine($"50 + m: {50 + m}");

        Console.WriteLine($"m - 30: {m - 30}");
        Console.WriteLine($"30 - m: {30 - m}");

        uint rub = (uint)m;
        double kop = m;

        Console.WriteLine($"приведение к uint: {rub}");
        Console.WriteLine($"приведение к double: {kop:F2}");

        Console.WriteLine("\nнажмите любую клавишу...");
        Console.ReadKey();
    }
}