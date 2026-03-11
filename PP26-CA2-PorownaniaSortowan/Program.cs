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
    }
}