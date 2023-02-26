int x, y, r, c;

int[,] simple = new int[50,50];
int[,] tran = new int[50, 50];
Console.WriteLine("Please give Row Number.");
r = int.Parse(Console.ReadLine()!);
Console.WriteLine("Please give Coloum Number.");
c = int.Parse(Console.ReadLine()!);
Console.WriteLine("Please give Row*Col Value.");
for (int i = 0;i < r; i++)
{
	for (int j = 0; j < c; j++)
	{
        Console.Write($"[{i}]x[{j}] : " );
        simple[i, j] = int.Parse(Console.ReadLine()!);
    }
}
Console.WriteLine("the simple matrix is ");
for (int i = 0; i < r; i++)
{
    for (int j = 0; j < c; j++)
    {
        Console.Write($"\t{simple[i, j]}");
    }
    Console.WriteLine();
}

for (int i = 0;i<r; i++)
{
    for (int j = 0; j < c; j++)
    {
        tran[j, i] = simple[i, j];
    }
}

Console.WriteLine("The transfer row to coloum matrix is ");
for (int i = 0; i < r; i++)
{
    for (int j = 0; j < c; j++)
    {
        Console.Write($"\t{tran[i, j]}");
    }
    Console.WriteLine();
}
