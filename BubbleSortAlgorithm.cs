using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Shopping
{
    public class BubbleSortAlgorithm
    {
        Swapper swapper = new Swapper();

        public void Sort(double[] prices)
        {
            for (int i = prices.Length - 1; i > 0; i--)
            {
                bool sorted = true;
                for (int j = 0; j < i; j++)
                {
                    if (prices[j] > prices[j + 1])
                    {
                        swapper.Swap(prices, j, j + 1);
                        sorted = false;
                    }
                }
                if (sorted)
                {
                    return;
                }
            }

        }
    }
}
                
        
    

