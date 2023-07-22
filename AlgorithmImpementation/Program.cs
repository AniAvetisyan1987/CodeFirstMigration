internal class Program
{
    private static void Main(string[] args)
    {
        int[] a = { 3, 0, 2, 5, -1, 4, 1 };
        int t;
        Console.WriteLine("Original array :");
        foreach (int aa in a)
            Console.Write(aa + " ");
        for (int p = 0; p <= a.Length - 2; p++)
        {
            for (int i = 0; i <= a.Length - 2; i++)
            {
                if (a[i] > a[i + 1])
                {
                    t = a[i + 1];
                    a[i + 1] = a[i];
                    a[i] = t;
                }
            }
        }
        Console.WriteLine("\n" + "Sorted array :");
        foreach (int aa in a)
            Console.Write(aa + " ");
        Console.Write("\n");

        Console.WriteLine( "searching algorithm");
        int[] arr = { 1, 5, 2, 38, 7 };
        LinerSearch(arr, 3);
        Console.WriteLine("Hello, World!");
    }

    static void LinerSearch(int[] arr,int key)
    {
        bool a = false;
        foreach(int i in arr)
        {
            if (i == key)
            {
                a = true;
            }
        } 
        if (a)
        {
            Console.WriteLine("System found searched number");
        }
        else
        {
            Console.WriteLine("System didn't find searched number");
        }
    }

    public int[] SortArray(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            var key = arr[i];
            var flag = 0;
            for (int j = i - 1; j >= 0 && flag != 1;)
            {
                if (key < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j--;
                    arr[j + 1] = key;
                }
                else flag = 1;
            }
        }
        return arr;
    }
}