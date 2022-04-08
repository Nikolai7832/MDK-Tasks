namespace Task5
{ 
    public class Programm
    {
        static void Main ()
        {
            int a = 38;
            int b = 66;
            Console.WriteLine($"a = {a}, b = {b}");
            string str = $"{a}";
           CheckIsEquals(str);
            str = $"{b}";
            CheckIsEquals(str);
            Console.ReadLine();
        }
        static void CheckIsEquals(string str)
        {
            if (str.First() == str.Last())
            {
                Console.WriteLine("Цифры одинаковые");
            }
            else
            Console.WriteLine("Цифры разные");
        }
    }
}
