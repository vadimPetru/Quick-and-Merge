using QuickSortAlgorithm;

Random rand = new();
int[] inputArray = new int[20];
for(int i = 0; i < inputArray.Length; i++)
{
    inputArray[i] = rand.Next(0, 20);
}


Quick quick = new();

int[] sortedArray = quick.QuickSort(inputArray, 0, inputArray.Length - 1);
Console.WriteLine($"Sorted array:{string.Join(",",sortedArray)}");

 


