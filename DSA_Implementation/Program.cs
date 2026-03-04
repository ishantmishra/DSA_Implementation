using DSA_Implementation;
using DSA_Implementation.Arrays;

public class Program: Array2D
{
    public static void Main(string[] args)
    {
        //ArrayPrint();
        int[] arr = { 100, 82, 73, 64, 55, 46, 39, 22, 11, 6};
        int target = 73;

        int[] arr2 = { 1, 2, 3, 4, 5, 6, 7};
        int target2 = 6;

        int ans = BinarySearch.binarySearch(arr, target);
        Console.WriteLine(ans);

        int ans2 = BinarySearch.binarySearch(arr2, target2);
        Console.WriteLine(ans2);
    }
}