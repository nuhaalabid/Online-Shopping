namespace Online_Shopping
{
    public class Swapper
    {
        public void Swap(double[] array, int index1, int index2)
        {
            double temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
    }

}
