int quant = 5;
int[] array = new int [quant];
int pol = 0;
Console.Write($"Input {quant} numbers with space between: ");
string[] st = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
for (int j = 0; j < quant; j++) 
{
	array[j] = int.Parse(st[j]);
	if (array[j] > 0) pol = pol + 1;
}
Console.Write($"Quantity of positive numbers is {pol}");