namespace SortArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
            
            int rowNumber = array.GetLength(0);
            int colNumber = array.GetLength(1);
            
            int[] peerArray = new int[rowNumber * colNumber];

            Console.WriteLine("Исходный двумерный массив:");
            PrintArray(array);

            // Преобразуем в одноранговый массив
            int count = 0;
            for (int i = 0; i < rowNumber; i++) 
            {
                for (int j = 0; j < colNumber; j++)
                {
                    peerArray[count] = array[i, j];
                    count++;
                }
            }
            
            Array.Sort(peerArray);

            count = 0;
            for (int i = 0; i < rowNumber; i++)
            {
                for (int j = 0; j < colNumber; j++)
                {
                    array[i, j] = peerArray[count];
                    count++;
                }
            }

            Console.WriteLine("\nОтсортированный двумерный массив:");
            PrintArray(array);

        }
        
        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    Console.Write(array[i, j] + " ");

                Console.WriteLine();
            }
        }
    }
}
