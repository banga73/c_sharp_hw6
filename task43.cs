double[] array = new double [4];
Console.Write($"Input 4 numbers with space between - b1, k1, b2, k2: ");
string[] st = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
for (int j = 0; j < 4; j++) 
{
	array[j] = double.Parse(st[j]);
}
double XCross = (array[2] - array[0]) / (array[1] - array[3]);
double YCross = array[1] * XCross + array[0];
Console.Write($"X of cross-point is {XCross}; Y of cross-point is {YCross}");