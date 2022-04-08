namespace Task6
{
    public class Programm
    {
        static void Main()
        {
            for (int i = 1; i <= 30; i++)
            {
                Console.WriteLine($"{i}^2 = {Math.Pow(i, 2)}");
            }
            Console.ReadLine();
        }
    }
}