using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Shopping
{
    public class QuicksortAlgorithm
    {
        Swapper swapper = new Swapper();

        public void Sort(double[] array)
        {
            Sort(array, 0, array.Length - 1);
        }

        private void Sort(double[] array, int start, int end)
        {
            if (start < end)
            {
                int pivotIndex = Partition(array, start, end);
                Sort(array, start, pivotIndex - 1);
                Sort(array, pivotIndex + 1, end);
            }
        }
        private int Partition(double[] array, int start, int end)
        {
            double pivot = array[end];
            int pivotIndex = start;

            for (int i = start; i < end; i++)
            {
                if (array[i] < pivot)
                {
                    swapper.Swap(array, i, pivotIndex);
                    pivotIndex++;
                }
            }

            swapper.Swap(array, pivotIndex, end);
            return pivotIndex;
        }
    }
}
    

   