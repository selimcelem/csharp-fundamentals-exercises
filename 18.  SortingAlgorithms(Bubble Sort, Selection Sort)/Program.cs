//Create an array of integers, e.g. int[] numbers = { 64, 25, 12, 22, 11 };

//Use nested loops:

//Outer loop: controls how many passes you do.

//Inner loop: compares each pair of elements and swaps them if the left is bigger.

//After sorting, print the sorted array.

#define BUBBLE_SORT
//#define SELECTION_SORT

using System;
using System.Globalization;

class SortingAlgorithms
{
    static void Main()
    {
        int[] numbers = { 64, 25, 12, 22, 11 };

#if BUBBLE_SORT
        Console.WriteLine("Using Bubble Sort:");
        BubbleSort(numbers);
#elif SELECTION_SORT
        Console.WriteLine("Using Selection Sort:");
        SelectionSort(numbers);
#else
        Console.WriteLine("No sort algorithm defined!");
#endif

        Console.WriteLine("Sorted array: " + string.Join(", ", numbers));
    }

    static void BubbleSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++) // Outer loop controls how many passes we do through the array.
        // We subtract 1 because after the (n - 1)th pass, the largest elements have "bubbled up" to the end, so no need to check that last one.
        {
            for (int j = 0; j < array.Length - i - 1; j++) // Inner loop compares each pair of adjacent elements.
            // With each pass, the largest value gets placed correctly at the end, so we subtract (i + 1) to avoid rechecking already sorted values.
            {
                if (array[j] > array[j + 1]) // If the current element is bigger than the next one...
                {
                    int temp = array[j]; // ...store the current (larger) value in a temporary variable...
                    array[j] = array[j + 1]; // ...move the smaller value to the current position...
                    array[j + 1] = temp; // ...and put the larger value one position ahead — effectively swapping them.
                }
            }
        }
    }

    static void SelectionSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++) // Loop through each element, except the last one (already sorted)
        {
            int minIndex = i; // Assume the current index is the smallest
            for (int j = i + 1; j < array.Length; j++) // Look at the rest of the array
            {
                if (array[j] < array[minIndex]) // If a smaller element is found
                {
                    minIndex = j; // Update the index of the smallest element
                }
            }
            int temp = array[minIndex]; // Store the smallest value temporarily
            array[minIndex] = array[i]; // Move the current value to where the smallest was
            array[i] = temp; // Put the smallest value into its correct position
        }
    }
}
