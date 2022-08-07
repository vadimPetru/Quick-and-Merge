using MergeSortAlgorithm;


int[] array = new int[10];
int[] array2 = new int[10];
MergeSortAlgoritnm  first = new(array,array2);
first.FullArray(array);
first.MergeSort(0, array.Length - 1);

first.Show();