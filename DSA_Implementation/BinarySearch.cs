namespace DSA_Implementation
{
    public class BinarySearch
    {
        public static int binarySearch(int[] arr, int target)
        {
            int start = 0, end = arr.Length - 1;

            // Order Agnostic binary Search
            Boolean isAsc = arr[start] < arr[end];

            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (arr[mid] == target)
                {
                    return mid;
                }

                if (isAsc)
                {
                    if (arr[mid] < target)
                    {
                        start = mid + 1;
                    }
                    else if (arr[mid] > target)
                    {
                        end = mid - 1;
                    }
                }
                else
                {
                    if (arr[mid] > target)
                    {
                        start = mid + 1;
                    }
                    else if (arr[mid] < target)
                    {
                        {
                            end = mid - 1;
                        }
                    }
                }
            }
            return -1;
        }
    }
}
