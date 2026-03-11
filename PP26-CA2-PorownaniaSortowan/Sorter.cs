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
    }
}
