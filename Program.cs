using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
        
           
            InsertArray(ref arr , 23 ,22, 4);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
        static void InsertArray(ref int[] arr, params int[] value)
        {
            int[] newArray = new int[arr.Length + value.Length];
            int j = 0;
            for (int i = 0;i < arr.Length;i++)
            {
                newArray[i] = arr[i];
            }
            for (int i =arr.Length; i < newArray.Length; i++)
            {
                 newArray[i] = value[j];
                j++;
            }
                
           arr= newArray;
        }
        }
    }


