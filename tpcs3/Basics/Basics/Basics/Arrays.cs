using System;
using System.IO.Ports;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Formatters;

namespace Basics
{
    public class Arrays
    {
        public static int Search(int[] arr, int e)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == e)
                    return i;               
            return -1;
        }
        
        public static int KingOfTheHill(int[] arr)
        {
            int max = arr[0];
            
            for (int i = 1; i < arr.Length; i++)
                if (max < arr[i])
                    max = arr[i];           
            return max;
        }

        public static int[] CloneArray(int[] arr)
        {
            int[] clone;
            clone = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                clone[i] = arr[i];
                Console.Write(clone[i]);
            }

            return clone;
        }

        public static void BubbleSort(int[] arr)
        {
            int n;
            int l = arr.Length;
            bool exchange = false;
            
            for (int i = l; i > 0; i--)
            {
                for (int j = 0; j < i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {   
                        n = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = n;            
                    }
            }                              
        }      
    }
}