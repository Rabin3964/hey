using System;
using System.Diagnostics;

namespace ConsoleApp2
{
    public class Rabin
    {
        public int[] arr = { 10, 20, 11, 4, 5, 18 };
    }
        class quicksort
        {
            static int partition(int[] arr, int low,
                                  int high)
            {
                int pivot = arr[high];


                int i = (low - 1);
                for (int j = low; j < high; j++)
                {

                    if (arr[j] < pivot)
                    {
                        i++;


                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }


                int temp1 = arr[i + 1];
                arr[i + 1] = arr[high];
                arr[high] = temp1;

                return i + 1;
            }

            static void quickSort(int[] arr, int low, int high)
            {
                if (low < high)
                {


                    int pi = partition(arr, low, high);

                    quickSort(arr, low, pi - 1);
                    quickSort(arr, pi + 1, high);
                }
            }

            static void print1(int[] arr, int n)
            {
                Stopwatch sw = Stopwatch.StartNew();
                for (int i = 0; i < n; ++i)
                    Console.Write(arr[i] + " ");

                sw.Stop();
                Console.WriteLine();
                Console.WriteLine("Time taken by quicksort is: {0} milli", sw.Elapsed.TotalMilliseconds);


            }
            public void quicks()
            {
            Rabin r = new Rabin();
            
                
                int n = r.arr.Length;


                quickSort(r.arr, 0, n - 1);

                Console.WriteLine("Sorted array by quicksort is:");
                print1(r.arr, n);


            }
        }

        class bubblesorts
        {
            public static void bubblesort(int[] arr)
            {
                int n = arr.Length;
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n - i - 1; j++)
                        if (arr[j] > arr[j + 1])
                        {
                            int temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;

                        }

            }
            public static void print(int[] arr)
            {
                int n = arr.Length;
                Stopwatch sw = Stopwatch.StartNew();
                for (int i = 0; i < n; i++)
                    Console.WriteLine(arr[i] + " ");

                sw.Stop();

                Console.WriteLine("Time taken by bubblesort is: {0} milli", sw.Elapsed.TotalMilliseconds);

            }
            public void bubbles()
            {
            Rabin r = new Rabin();


                bubblesort(r.arr);
                Console.WriteLine();
                Console.WriteLine("sorted array by bubblesort is:");
                print(r.arr);

            }


        }

        class heapsort
        {
            public void sort(int[] arr)
            {
                int n = arr.Length;


                for (int i = n / 2 - 1; i >= 0; i--)
                    heapify(arr, n, i);


                for (int i = n - 1; i >= 0; i--)
                {

                    int temp = arr[0];
                    arr[0] = arr[i];
                    arr[i] = temp;


                    heapify(arr, i, 0);
                }
            }


            void heapify(int[] arr, int n, int i)
            {
                int largest = i;
                int l = 2 * i + 1;
                int r = 2 * i + 2;

                if (l < n && arr[l] > arr[largest])
                    largest = l;


                if (r < n && arr[r] > arr[largest])
                    largest = r;

                if (largest != i)
                {
                    int swap = arr[i];
                    arr[i] = arr[largest];
                    arr[largest] = swap;


                    heapify(arr, n, largest);
                }
            }


            static void printArray(int[] arr)
            {

                int n = arr.Length;
                Stopwatch sw = Stopwatch.StartNew();
                for (int i = 0; i < n; ++i)
                    Console.Write(arr[i] + " ");
                sw.Stop();
                Console.WriteLine();
                Console.WriteLine("Time taken by Heapsort is: {0} milli", sw.Elapsed.TotalMilliseconds);


            }


            public void heaps()
            {
            Rabin r = new Rabin();
                int n = r.arr.Length;

                heapsort ob = new heapsort();
                ob.sort(r.arr);
                Console.WriteLine();
                Console.WriteLine("Sorted array according to heapsort is");
                printArray(r.arr);
            }
        }

        class mergesort
        {
            public static void mergemethod(int[] arr, int left, int mid, int right)
            {
                int[] temp = new int[25];
                int i, left_end, num_elements, tmp_pos;
                left_end = (mid - 1);
                tmp_pos = left;
                num_elements = (right - left + 1);
                while ((left <= left_end) && (mid <= right))
                {
                    if (arr[left] <= arr[mid])
                        temp[tmp_pos++] = arr[left++];
                    else
                        temp[tmp_pos++] = arr[mid++];
                }
                while (left <= left_end)
                    temp[tmp_pos++] = arr[left++];
                while (mid <= right)
                    temp[tmp_pos++] = arr[mid++];
                for (i = 0; i < num_elements; i++)
                {
                    arr[right] = temp[right];
                    right--;
                }

            }
            static public void sortmethod(int[] numbers, int left, int right)
            {
                int mid;
                if (right > left)
                {
                    mid = (right + left) / 2;
                    sortmethod(numbers, left, mid);
                    sortmethod(numbers, (mid + 1), right);
                    mergemethod(numbers, left, (mid + 1), right);

                }
            }
            public void merge()

            {

            Rabin r = new Rabin();
                int len = r.arr.Length;
                Stopwatch sw = Stopwatch.StartNew();
                Console.WriteLine();
                Console.WriteLine("MergeSort :");
                sortmethod(r.arr, 0, len - 1);
                for (int i = 0; i < len; i++)
                    Console.WriteLine(r.arr[i]);
                sw.Stop();

                Console.WriteLine("Time taken by mergesort is: {0} milli", sw.Elapsed.TotalMilliseconds);


            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                quicksort q = new quicksort();
                bubblesorts b = new bubblesorts();
                heapsort h = new heapsort();
                mergesort m = new mergesort();
                q.quicks();
                b.bubbles();
                h.heaps();
                m.merge();


                Console.ReadLine();

            }
        }
    }

