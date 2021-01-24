using System;

namespace MultiDimensionalArrays
{
    class ProgramMDArrays
    {
        static int dimensions;
        static int[] dimensionArray;
        static int[] elements;
        static int[,] myMDArray;
        static void Main(string[] args)
        {
            dimensions = GetNumbers("Enter number of dimensions in your array: ");
            dimensionArray = GetArrayFromInt(dimensions);
            elements = GetNumberOfElements();
            CreateMDArray();



            //IterateThroughArray();
            //PrintOut();
        }

        private static void CreateMDArray()
        {
            myMDArray = new int[,];
        }

        private static int[] GetNumberOfElements()
        {
            for (int i = 0; i < dimensionArray.Length; i++)
            {
                bool isNaN;
                int value;
                Console.Write($"Enter number of elements in dimension number {dimensionArray[i]}: ");
                elements = new int[dimensionArray.Length];
                do
                {
                    isNaN = int.TryParse(Console.ReadLine(), out value);
                    if (isNaN)
                    {
                        Console.Write($"Entered number: {value}\n");
                        elements[i] = value;
                    } else
                    {
                        Console.Write("Enter a valid number: ");
                    }

                } while (!isNaN);
            }
            return elements;
        }

        private static int[] GetArrayFromInt(int dimensions)
        {
            dimensionArray = new int[dimensions];
            for (int i = 1; i <= dimensions; i++)
            {
                dimensionArray[i - 1] = i;
                //Console.WriteLine(dimensionArray[i - 1]);
            }
            return dimensionArray;
        }

        private static int GetNumbers(string askForInput)
        {
            Console.Write(askForInput);
            bool isNaN;
            int value;
            do
            {
                isNaN = int.TryParse(Console.ReadLine(), out value);
                if (isNaN)
                {
                    Console.Write($"Entered number: {value}\n");
                }
                else
                {
                    Console.Write("Enter a valid integer: ");
                }
            } while (!isNaN);
            return value;
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
