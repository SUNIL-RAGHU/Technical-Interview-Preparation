using System;


namespace basic
{
    class SortingAlgorithms
    {

        public static void Main(string[] args)
        {
            int[] arr = { 0, 1, 3, 2, 4, 5 };
            int[] arr1 = { 64, 34, 25, 12, 22, 11, 90 };
            BubbleSort(arr1);
            QuickSort(arr1, 0, arr1.Length - 1);
            printArray(arr1);
            InsertionSort(arr1);
            SelectionSort(arr);
        }

        private static void QuickSort(int[] arr1, int left, int right)
        {

            if (left < right)
            {
                int partion = Partion(arr1, left, right);

                QuickSort(arr1, left, partion - 1);
                QuickSort(arr1, partion + 1, right);
            }
        }
        private static int Partion(int[] arr1, int left, int right)
        {

            int part = arr1[right];
            int i = (left - 1);

            for (int j = left; j < right; j++)
            {
                if (arr1[j] < part)
                {
                    i++;
                    Swap(arr1, i, j);
                }
            }
            Swap(arr1, i + 1, right);
            return (i + 1);
        }

        private static void printArray(int[] arr){
            foreach(var val in arr){
                Console.Write(val+" ");
            }
        }

        private static void InsertionSort(int[] arr1)
        {
            for (int i = 1; i < arr1.Length; i++)
            {

                int Current = arr1[i];
                int j = i - 1;

                while (j >= 0 && arr1[j] > Current)
                {
                    arr1[j + 1] = arr1[j];
                    j--;
                }

                arr1[j + 1] = Current;
            }

            printArray(arr1);
        }

        private static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {

                int Minindex = i;

                for (int j = i + 1; j < arr.Length; j++)
                {

                    if (arr[Minindex] > arr[j])
                    {
                        Minindex = j;
                    }
                }

                if (Minindex != i)
                {
                    Swap(arr, i, Minindex);
                }
            }

            printArray(arr);
        }




        private static void Swap(int[] arr, int i, int minindex)
        {
            int temp = arr[i];

            arr[i] = arr[minindex];

            arr[minindex] = temp;
        }

        private static void BubbleSort(int[] arr)
        {

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {

                    if (arr[j] > arr[j + 1])
                    {
                        Swap(arr, j, j + 1);

                    }
                }
            }

            printArray(arr);
        }


    }
}
