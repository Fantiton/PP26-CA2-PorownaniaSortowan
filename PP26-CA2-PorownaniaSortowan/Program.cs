using PP26_CA2_PorownaniaSortowan;

public class Program
{
    public static void Main()
    {
        Sorter sorter = new Sorter();
        int[] inputTable = { 5, 2, 9, 1, 5, 6 };

        int[] bubbleSortedTable = sorter.BubbleSort(inputTable);
        Console.WriteLine("Bubble Sorted Table: " + string.Join(", ", bubbleSortedTable));

        int[] selectionSorterTable = sorter.SelectionSort(inputTable);
        Console.WriteLine("Selection Sorted Table: " + string.Join(", ", selectionSorterTable));

        int[] quickSortedTable = sorter.QuickSort(inputTable);
        Console.WriteLine("Quick Sorted Table: " + string.Join(", ", quickSortedTable));

        int elementToFind = 5;
        int foundIndex = sorter.Find(quickSortedTable, elementToFind);
        if(foundIndex != -1)
        {
            Console.WriteLine($"Szukany element: {elementToFind} znaleziony element: {quickSortedTable[foundIndex]} na indeksie: {foundIndex}");
        }
        else
        {
            Console.WriteLine($"Szukany element: {elementToFind} nie został znaleziony.");
        }
    }
}