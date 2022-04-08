namespace ArrayMaker
{
    public class ArrMaker
    {
        Random rand = new Random();
       public  int[,] Arr = new int[5, 2];
        internal ArrMaker()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 2; j++)
                {
                    Arr[i, j] = rand.Next(10000);
                    Console.Write($" {Arr[i, j]}");
                }
            }
        }
       static internal int Sum (ArrMaker array)
        {
            int sum = 0;
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 2; j++)
                { 
                    if ( array.Arr[i,j] % 2 == 0)
                    {
                        sum += array.Arr[i, j];
                    }
                }
            return sum;
        }
    }
    public class Programm
    {
        static void Main ()
        {
            ArrMaker m = new ArrMaker();
            Console.WriteLine();
            Console.WriteLine($"Сумма четных элементов равна: {ArrMaker.Sum(m)}");
            Console.ReadLine();
        }
    }
}