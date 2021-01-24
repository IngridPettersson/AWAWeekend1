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
            elemDim1 = GetNumberOfElements("Enter number of elements in first dimension: ");
            elemDim2 = GetNumberOfElements("Enter number of elements in second dimension: ");
            CreateMDArray();
            //IterateThroughArray();
            //PrintOut();
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
                        Console.Write($"Entered number: {value}\n");
                        elements = value;
                    } else
                    {
                        Console.Write("Enter a valid integer: ");
                    }

                } while (!isNaN);
            return elements;
        }

        private static void CreateMDArray()
        {
            my2DArray = new int[elemDim1, elemDim2];
            for (int i = 0; i < my2DArray.GetLength(0); i++)
                for (int j = 0; j < my2DArray.GetLength(1); j++)
                {
                    Console.WriteLine(my2DArray[i, j]);
                }
        }

        private static void IterateThroughArray()
        {
            throw new NotImplementedException();
        }

        private static void PrintOut()
        {
            throw new NotImplementedException();
        }

        // for(inti=0; i<myList.GetLength(0);i++)for(intj=0; j<myList.GetLength(1);j++)Console.WriteLine(myList[i, j]);
    }
}
