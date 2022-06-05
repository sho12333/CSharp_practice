class Program{

    public static void BubbleSort(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for(int j = i+1; j < array.Length; j++)
            {
                if(array[i] > array[j])
                {
                    int tmp = array[i];
                    array[i] = array[j];
                    array[j] = tmp;
                }
            }
        }
    }
    public static void Main()
    {
        int[] array = {5,3,6,2,1};
        BubbleSort(array);
        for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}
