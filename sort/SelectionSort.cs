class Program{

    public static void SelectionSort(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int minId = i;
            for (int j = i+1; j < array.Length; j++)
            {
                minId = array[j] < array[minId] ? j : minId;
            }
            if(array[i] != array[minId])
            {
                int tmp = array[i];
                array[i] = array[minId];
                array[minId] = tmp;
            }
        }
    }
    public static void Main()
    {
        int[] array = {5,3,6,2,1};
        SelectionSort(array);
        for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}
