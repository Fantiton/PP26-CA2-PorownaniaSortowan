using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP26_CA2_PorownaniaSortowan
{
    public class Sorter
    {
        public int[] BubbleSort(int[] inputTable)
        {
            for(int i = 0; i < inputTable.Length; i++)
            {
                for (int j = 0; j < inputTable.Length - 1; j++)
                {
                    if (inputTable[j] > inputTable[j + 1])
                    {
                        int temp = inputTable[j];
                        inputTable[j] = inputTable[j + 1];
                        inputTable[j + 1] = temp;
                    }
                }
            }  

            return inputTable;
        }

        public int[] SelectionSort(int[] inputTable)
        {
            for(int i = 0; i < inputTable.Length; i++)
            {
                int lowestIndex = i;
                for (int j = i; j < inputTable.Length; j++)
                {
                    if (inputTable[j] < inputTable[lowestIndex]) lowestIndex = j;
                }

                int temp = inputTable[i];
                inputTable[i] = inputTable[lowestIndex];
                inputTable[lowestIndex] = temp;
            }

            return inputTable;
        }

        public int[] QuickSort(int[] inputTable)
        {
            return QuickSort(inputTable, 0, inputTable.Length - 1);
        }
        private int[] QuickSort(int[] array, int left, int right)
        {
            int i = left;
            int j = right;
            int pivot = array[(left + right) / 2];

            while (i <= j)
            {
                while (array[i] < pivot) i++;
                while (array[j] > pivot) j--;

                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;

                    i++;
                    j--;
                }
            }

            if (left < j)
                QuickSort(array, left, j);

            if (i < right)
                QuickSort(array, i, right);

            return array;
        }
    }
}
