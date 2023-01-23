// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please give your jagged array size.");
int num = Int32.Parse(Console.ReadLine());
int[][] number = new int[num][];
for (int i = 0; i < number.Length; i++)
{
    Console.WriteLine("Please give "+ i +" number array of array size.");
    int arraySize = Int32.Parse(Console.ReadLine());
    number[i] = new int[arraySize];
    for (int j=0; j< arraySize; j++)
    {
        Console.WriteLine("The " + j+ "th value.");
        number[i][j] = Int32.Parse(Console.ReadLine());
    }
}

Console.WriteLine("Now print array value.");

for (int m=0; m<number.Length; m++)
{
    int[] arrayElement = number[m];
    Console.WriteLine("Number of array " + m);
    for (int n=0;n< arrayElement.Length; n++)
    {
        Console.WriteLine("the arrray value " + arrayElement[n]);
    }
   
}


