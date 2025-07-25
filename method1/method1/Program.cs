using System.Globalization;

namespace method1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a)

            //int[] numbers = [4, 2, 8, 5, 9, 1, 0, 3, 100,-3,1];
            //Console.WriteLine(GetMin(numbers));


            //b)

            //int[] numbers = { 1, 5, 2, 7, 3, 4, 8, 100 };
            //SortArray(numbers);
            //for (int i =0;i< numbers.Length;i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //c)

            //Console.WriteLine(GetPower(4));
        }
        public static int GetMin(int[] numbers)
        {
            int min = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            return min;
        }
        public static int[] SortArray (params int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    int temp= numbers[i];
                    numbers[i]= numbers[i + 1];
                    numbers[i+1]= temp;
                    i = 0;
                }
            }
            return numbers;
        }
        public static int GetPower (int num,int power=2)
        {
            int powered = 1;
            for (int i = 1; i <= power; i++)
            {
                powered *= num;
            }
            return powered;

        }
        
    }
}
