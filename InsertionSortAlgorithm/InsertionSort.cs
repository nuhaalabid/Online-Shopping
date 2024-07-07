using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Shopping.InsertionSort
{
    public class InsertionSort
    {
        public static void Sort(Product[] products)
        {
            int n = products.Length;
            for (int i = 1; i < n; ++i)
            {
                Product key = products[i];
                int j = i - 1;

                while (j >= 0 && string.Compare(products[j].Name, key.Name) > 0)
                {
                    products[j + 1] = products[j];
                    j = j - 1;
                }
                products[j + 1] = key;
            }
        }

    }
}
