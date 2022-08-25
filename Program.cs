// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace BubbleSort
{
    class program
    {
        public static void Main(string[] args)
        {
            int[] arr= { 68, 50, 41, 88, 9 };
            int temp;

            for(int j = 0; j <= arr.Length - 2; j++)
            {
                for(int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i+1])
                    {
                        temp = arr[i+1];
                        arr[i+1] = arr[i];  
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted");

            foreach(int p in arr)
            {
                Console.Write(p + " ");
                Console.Read();
            }
        }
    }
}