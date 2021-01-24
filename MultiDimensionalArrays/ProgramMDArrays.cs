using System;

namespace MultiDimensionalArrays
{
    class ProgramMDArrays
    {
        static int elements;
        static int[,] my2DArray;
        static int elemDim1;
        static int elemDim2;
        static void Main(string[] args)
        {
            Console.WriteLine("Let's create a two-dimensional array!\n".ToUpper());
            elemDim1 = GetNumberOfElements("Enter number of elements in first dimension: ");
            elemDim2 = GetNumberOfElements("Enter number of elements in second dimension: ");
            Create2DArray();
            PrintOut();
        }

        private static int GetNumberOfElements(string askForUserInput)
        {
                bool isNaN;
                int value;
                Console.Write(askForUserInput);
                do
                {
                    isNaN = int.TryParse(Console.ReadLine(), out value);
                    if (isNaN)
                    {
                        elements = value;
                    } else
                    {
                        Console.Write("Enter a valid integer: ");
                    }

                } while (!isNaN);
            return elements;
        }

        private static void Create2DArray()
        {
            my2DArray = new int[elemDim1, elemDim2];
            for (int i = 0; i < my2DArray.GetLength(0); i++)
                for (int j = 0; j < my2DArray.GetLength(1); j++)
                {
                    Console.Write($"Enter a value for row {i + 1}, column {j + 1}: ");
                    int specificValue = Convert.ToInt32(Console.ReadLine());
                    my2DArray[i, j] = specificValue;
                }
        }

        private static void PrintOut()
        {
            Console.Clear();
            Console.WriteLine("Here is your array:".ToUpper());
            for (int i = 0; i < my2DArray.GetLength(0); i++)
                for (int j = 0; j < my2DArray.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        Console.Write($"\n{my2DArray[i, j]}  ");
                    }
                    else
                    {
                    Console.Write($"{my2DArray[i,j]}  ");
                    }
                }
            Console.WriteLine();
        }

        // for(inti=0; i<myList.GetLength(0);i++)for(intj=0; j<myList.GetLength(1);j++)Console.WriteLine(myList[i, j]);
    }
}
