// See https://aka.ms/new-console-template for more information

using BasicPractics;
//new Swap().swap();

//new Swap().swapwithtemp();

//new Swap().swapwith();
/*
int number = int.Parse(Console.ReadLine());
int[] num = new int[number];
int i;
for (i = 0;i < number; i++)
{
    Console.WriteLine("Give "+i+"th position value");
    int nums = int.Parse(Console.ReadLine());
    num[i] = nums;
    
}*/
//Console.WriteLine(num);
int nums = int.Parse(Console.ReadLine());
int nums1 = int.Parse(Console.ReadLine());

for (int m = 0; m< nums; m++)
{
    for (int n = nums1; n>m; n--)
    {
        Console.Write(nums);
    }
    Console.WriteLine();
    
}


