using System.Collections;

namespace OopPractise
{
    class Program
    {
        public static void Main(string[] args)
        {



            //////////////////////////////// Single Dimensional Array ////////////////////////////////
            int[] num = { 4, 5, 6, 9, 5, 8, 3 };

            //foreach (int i in num)
            //{
            //    Console.Write(i);
            //}

            int[] ARR = new int[5] { 1, 2, 3, 8, 5 };
            /*
             for(int i = 0; i < ARR.Length; i++) // Get a specifc value of an array
             {
               int j = ARR[i];
                 if(j == 8)
                 {
                     Console.WriteLine("Yes the value is 8");
                 }
             } */

            /*
            int j1 = 0;
            for(int i = 0; i < ARR.Length; i++) // Get the index of a specific Valua of an array
            {
                int j = ARR[i];
                if(j == 8)
                {
                    Console.WriteLine("The index of 8 is " + i);
                }
            } */


            /*
            for (int i = 0; i < ARR.Length; i++) //Print an Array Element
            {
                Console.WriteLine(ARR[i]);
            }
            foreach (var item in ARR)
            {
                Console.WriteLine(item);
            }
            for (int i = 0; i < ARR.Length; i++)
            {
                ARR[i] = ARR[i] + 15;
                Console.WriteLine(ARR[i]);
            }
            Console.WriteLine(ARR.Count());
            */



            int[] evenNums;
            evenNums = new int[5];
            // or
            evenNums = new int[] { 2, 4, 6, 8, 10, 11, 15 };
            Array.Reverse(evenNums);
            Console.WriteLine(evenNums);
            Console.WriteLine(evenNums.Count());
            Console.WriteLine(evenNums.Length);
            //Array.Sort(evenNums);

            //int[] array = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3 };
            //Array.Sort(array);
            //foreach (int item in array)
            //{
            //    Console.Write(item);
            //}

            //evenNums = evenNums.Concat(ARR).ToArray();
            //foreach (int item in evenNums)
            //{
            //    Console.Write(item);
            //}

            //Console.WriteLine("Array Link Operation");
            //Console.WriteLine(ARR.Max());
            //Console.WriteLine(ARR.Min());
            //Console.WriteLine(ARR.Sum());
            //Console.WriteLine(ARR.Average());


            // Console.WriteLine(evenNums.ToList().IndexOf(10).ToString());//Get the index of a Specific Element of an Array


            //num = num.Union(evenNums).ToArray();//Union of 2 Array
            //foreach(int num2 in num)
            //{
            //    Console.WriteLine(num2);
            //}



            ////////////////////////////////// Multi Dimensional Array ////////////////////////////////

            //int[,] TDarr = new int[4, 2] {
            //    { 9,6 },
            //    { 7,5 },
            //    { 6,5 },
            //    { 8,6 } };

            //for (int i = 0; i < TDarr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < TDarr.GetLength(1); j++)
            //    {
            //        Console.Write(TDarr[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}




            //int[,] TwoDArray = new int[5, 2] {
            //    { 1, 2 },
            //    { 3, 4 },
            //    { 5, 6 },
            //    { 7, 8 },
            //    { 9, 10 }
            //};

            //for (int i = 0; i < TwoDArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < TwoDArray.GetLength(1); j++)
            //    {
            //        Console.Write(TwoDArray[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}




            ///////////////////////////// JAGGED ARRAY ///////////////////////////// 
            //int[][] jArray = new int[2][];

            //jArray[0] = new int[3] { 1, 2, 3 };

            //jArray[1] = new int[4] { 4, 5, 6, 7 };


            // ALTERNATIVE METHOD
            int[][] jArray1 = new int[2][]{
                new int[3]{1, 2, 3},

                new int[4]{4, 5, 6, 7}
            };


            for(int i = 0; i < jArray1.Length; i++)
            {
                for(int j = 0; j < jArray1[i].Length; j++)
                {
                    Console.Write(jArray1[i][j] + " ");
                }
                Console.WriteLine();
            }





















        }


    }
}