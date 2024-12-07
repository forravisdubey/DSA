using System;
using System.Collections.Generic;
using Algorigthms.Sorting;
using DS;

namespace Algorigthms
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Sort
            //quick sort
            //merge sort
            QuickSort.QuickSortTest();

            //merge sort
            MergeSort.MergeSorTest();
            //selection sort
            SelectionSort.SelectionSortTest();
            //Bubble
            BubbleSort.BubbleSorTest();
            #endregion
            #region ValidParan
            ValidParanthesis.ISValid("()");
            #endregion
            #region ThirdaMax
            int[] thirMaxList = new int[] { 3,2,1 };
            var thirdMax = ThirdMax.GEtThirdMax(thirMaxList);
            #endregion
            #region GroupAnagram
            string[] list = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            GroupAnagram.GroupThem(list);
            #endregion
            #region ticktaktoe
            TicTacToe ttt = new TicTacToe(2);
            int output = -1;
            output = ttt.Move(0, 1, 1);
            output = ttt.Move(1, 1, 2);
            output = ttt.Move(1, 0, 1);


            #endregion

            #region GetTopKFrequent

            int[] arr = new[] { 1, 1, 1, 2, 2,2,2, 3 };
            TopKFrequencies.GetTopKFrequent(arr,2);

            List<string> trucks = new List<string>();
            trucks.Add("truck1");
            trucks.Add("truck2");
            trucks.Add("truck3");
            trucks.Add("truck2");
            trucks.Add("truck5");
            trucks.Add("truck1");
            trucks.Add("truck2");
            var ans = MostFrequentTrucks.GetMostFrequentTruck(trucks, 2);

            #endregion

            LongestSubstringWithoutDuplicate.GetLongestSubString("abbbbbacdef");
            var count = CountPrime.CountPrimes(100);
            //rotate array
            // RotateArray p = new RotateArray();
            // int[] nums = new int[7] { 1,2,3,4,5,6,7};
            // p.Rotate(nums,3);

            ////var res = LongestSubstringWithoutDuplicate.GetLongestSubString("abc");
            ////[8,6,1,7,10,1]
            //LinkedList ls = new LinkedList(20);
            //ls.AddAtHead(10); ls.AddAtHead(6); ls.AddAtHead(4); ls.AddAtHead(2); ls.AddAtHead(1);

            ////[5,2,4,7,3,1]
            //LinkedList ls1 = new LinkedList(11);
            //ls1.AddAtHead(9); ls1.AddAtHead(7); ls1.AddAtHead(3); ls1.AddAtHead(2); ls1.AddAtHead(2);

            //MergeLinkedList.MergeTwoLists(ls.head, ls1.head);

            //ListNode temp = ls.head;

            //while (temp !=null)
            //{
            //    Console.WriteLine(temp.val);
            //    temp = temp.next;
            //}

            //Matrix tranpose
            int[,] matrix = new int[4,4];
            Random rd = new Random();
            for(int i = 0; i<matrix.GetLength(0);i++)
            {
                for(int j =0; j < matrix.GetLength(0); j ++)
                {
                    matrix[i, j] = rd.Next(0,100);
                    Console.Write(matrix[i, j] + ", ");
                }
                Console.WriteLine();
            }

            //var result = RotateAMatrix.RotateMatrixInPlace(matrix);

            //var result = TrasposeAMatrix.TransposeMatrix(matrix);
            //Console.WriteLine("Transposed");
            //Program.Pint(result);
            //Console.WriteLine("Reflect");
            //result = TrasposeAMatrix.ReflectMatrix(result);
            //Program.Pint(result);


            //Merge sorted array
            int[] ar1 = { 1, 2, 3, 0, 0, 0 };
            int[] ar2 = { 2, 5, 6 };
            MergeSortedArray.Merge(ar1, 3, ar2, 3);




        }

        public static void Pint(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    Console.Write(matrix[i, j] + ", ");
                }
                Console.WriteLine();
            }
        }

    }
}
