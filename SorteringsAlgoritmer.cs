using Online_Shopping.FactoryMethodPattern;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Shopping
{
    public class SorteringsAlgoritmer
    {
        QuicksortAlgorithm quicksortAlgorithm = new QuicksortAlgorithm();
        BubbleSortAlgorithm bubbleSortAlgorithm = new BubbleSortAlgorithm();
       
        public void Run()
        {

            double[] prices = { 999, 600, 850, 400, 780 };

            Stopwatch stopwatch = new Stopwatch();


            stopwatch.Start();

            // Skapa en instans av QuickSort och sortera prisen
            quicksortAlgorithm.Sort(prices);

            stopwatch.Stop();

            // Visa de sorterade priserna
            Console.WriteLine("Sorted prices (Quick Sort):");
            foreach (double price in prices)
            {
                Console.WriteLine(price);
            }

            // Skriv ut tiden det tog för sorteringen att slutföras
            Console.WriteLine("Quick Sort took " + stopwatch.ElapsedTicks + " ticks!");



            Console.WriteLine();

            double[] bubbleSortPrices = { 999, 600, 850, 400, 780 };

            Stopwatch stopwatchBubbleSort = new Stopwatch();

            stopwatchBubbleSort.Start();

            // Sortera priset med Bubble Sort-algoritmen
            bubbleSortAlgorithm.Sort(bubbleSortPrices);

            stopwatchBubbleSort.Stop();

            Console.WriteLine("Sorted prices (Bubble Sort):");
            foreach (double price in bubbleSortPrices)
            {
                Console.WriteLine(price);
            }

            // Skriv ut tiden det tog för sorteringen att slutföras med Bubble Sort
            Console.WriteLine("Bubble Sort took " + stopwatchBubbleSort.ElapsedTicks + " ticks!");
            Console.WriteLine();
        }


    }
}
    

