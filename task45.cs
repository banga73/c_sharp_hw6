int[] CopyArray(int[] array)
{
	int[] CopyArr = new int[array.Length];
	for (int i = 0; i < array.Length; i++)
	{
		CopyArr[i] = array[i];
	}
	return CopyArr;
}
int[] GetRandomArray(int size, int minValue, int maxValue)
{
	int[] result = new int[size];
	for (int i = 0; i < size; i++)
	{
		result[i] = new Random().Next(minValue, maxValue + 1);
	}
	return result;
}
void ShowArray(int [] array) 
{ 
	for(int i = 0; i < array.Length; i++) 
	{
		Console.Write(array [i] + " "); 
		Console.WriteLine(); 
	}
}
int[] OldArray = GetRandomArray(10, 1, 1000);
int[] NewArray = CopyArray(OldArray);
ShowArray(OldArray);
Console.WriteLine(); 
ShowArray(NewArray);