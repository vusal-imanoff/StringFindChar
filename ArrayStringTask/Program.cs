using System;

namespace ArrayStringTask
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Task-1
            //Console.WriteLine("Enter lenght of Array: ");
            //int lenght;
            //int.TryParse(Console.ReadLine(), out lenght);
            //int[] arr = new int[lenght];

            //int[] temp = CustomArraySort(arr);

            //Console.Write("New array: ");
            //foreach (int item in temp )
            //{
            //    Console.Write(item + " ");
            //}
            #endregion






            #region Task-2
            int i;
            Console.Write("enter symbol: ");
            char word;
            char.TryParse(Console.ReadLine(), out word);
            Console.WriteLine("enter lenght of array: ");
            int lenght;
            int.TryParse(Console.ReadLine(), out lenght);
            Console.WriteLine("Enter elements of Array ");
            string[] arr = new string[lenght];
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write($"Elements {i + 1}- ", i);
                arr[i] = Console.ReadLine().ToString();
            }
            for ( i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (word == arr[i][j])
                    {
                        Console.WriteLine(arr[i]);
                    }

                }
               

            }
            #endregion

            #region Task-2


            static int[] CustomArraySort(int[] arr)
            {


                for (int a = 0; a < arr.Length; a++)
                {
                    Console.Write($"Element of Array {a + 1}: ");
                    int.TryParse(Console.ReadLine(), out arr[a]);
                }
                int check = 0;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] > arr[j])
                        {
                            check = arr[i];
                            arr[i] = arr[j];
                            arr[j] = check;
                        }

                    }
                }
                return arr;
            }
            #endregion
        }
      
    }
}
