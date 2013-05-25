﻿using System;
using System.Linq;
using System.Diagnostics;

//1.Add assertions in the code from the project "Assertions-Homework" to ensure all possible preconditions and postconditions are checked.


class AssertionsHomework
{
    public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
    {
        if (arr == null)
        {
            throw new NullReferenceException("The array is not initialized!");
        }

        for (int index = 0; index < arr.Length-1; index++)
        {
            int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
            Swap(ref arr[index], ref arr[minElementIndex]);
        }

        for (int i = 0; i < arr.Length - 1; i++)
        {
            Debug.Assert(arr[i].CompareTo(arr[i + 1]) <= 0, "The array is not sorted!");
        }

    }
  
    private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex) 
        where T : IComparable<T>
    {
        Debug.Assert(arr != null, "The array is not initialized!");
        Debug.Assert(arr.Length > 0, "The array should not have zero elements!");
        Debug.Assert(startIndex >= 0, "The index should not be negative number!");
        Debug.Assert(startIndex < arr.Length, "The start index should be smaller than the length of the array!");
        Debug.Assert(endIndex < arr.Length, "The end index should be smaller than the length of the array!");
        Debug.Assert(startIndex <= endIndex, "Start indext should be smaller or equal to end index!");

        int minElementIndex = startIndex;
        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (arr[i].CompareTo(arr[minElementIndex]) < 0)
            {
                minElementIndex = i;
            }
        }
        return minElementIndex;
    }

    private static void Swap<T>(ref T x, ref T y)
    {
        T oldX = x;
        x = y;
        y = oldX;
    }

    public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
    {
        if (arr == null)
        {
            throw new NullReferenceException("The array is not initialized!");
        }
        if (value == null)
        {
            throw new NullReferenceException("The input value cannot be null!");
        }
        return BinarySearch(arr, value, 0, arr.Length - 1);
    }

    private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex) 
        where T : IComparable<T>
    {
        Debug.Assert(arr != null, "The array is not initialized!");
        Debug.Assert(arr.Length > 0, "The array should not have zero elements!");
        Debug.Assert(value != null, "The value cannot be null!");
        Debug.Assert(startIndex >= 0, "The index should not be negative number!");
        Debug.Assert(startIndex < arr.Length, "The start index should be smaller than the length of the array!");
        Debug.Assert(endIndex < arr.Length, "The end index should be smaller than the length of the array!");
        Debug.Assert(startIndex <= endIndex, "Start indext should be smaller or equal to end index!");

        while (startIndex <= endIndex)
        {
            int midIndex = (startIndex + endIndex) / 2;
            if (arr[midIndex].Equals(value))
            {
                return midIndex;
            }
            if (arr[midIndex].CompareTo(value) < 0)
            {
                // Search on the right half
                startIndex = midIndex + 1;
            }
            else 
            {
                // Search on the right half
                endIndex = midIndex - 1;
            }
        }

        // Searched value not found
        return -1;
    }

    static void Main()
    {
        int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
        Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
        SelectionSort(arr);
        Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

        SelectionSort(new int[0]); // Test sorting empty array
        SelectionSort(new int[1]); // Test sorting single element array

        Console.WriteLine(BinarySearch(arr, -1000));
        Console.WriteLine(BinarySearch(arr, 0));
        Console.WriteLine(BinarySearch(arr, 17));
        Console.WriteLine(BinarySearch(arr, 10));
        Console.WriteLine(BinarySearch(arr, 1000));
    }
}
