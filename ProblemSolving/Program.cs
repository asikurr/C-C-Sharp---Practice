// Problem Solving 

int n = int.Parse(Console.ReadLine());
int[][] jagar= new int[n][];
int i = 0;
while (i < n)
{
    string val = Console.ReadLine();
    string[] intVal = val.Split(" ");
    jagar[i] = intVal.Select(int.Parse).ToArray(); ;
    i++;
}


int views = 0;
for (int j = 0; j < n; j++)
{

    int count = 0;
    for (int k = 0; k < jagar[j].Length; k++)
        {
        if (count == 2)
        {
            count = 0;
        }
        if (jagar[j][k] == 1 )
        {
            count += 1;
           
        }
        if (count >= 2) {
            views = views + 1;
        }
        
        }
    
}
Console.WriteLine(views);






















//int num = int.Parse(Console.ReadLine());
//for (int i = 1; i <= num; i++)
//{
//    string n = Console.ReadLine().ToLower();
//    if (n.Length >= 1 && n.Length <= 100)
//    {
//        if (n.Length >= 11)
//        {
//            string fistIndex = n.Substring(0, 1);
//            int countVal = n.Length - 2;
//            string lastIndex = n.Substring(n.Length - 1);
//            Console.WriteLine("{0}{1}{2}", fistIndex, countVal, lastIndex);
//        }
//        else
//        {
//            Console.WriteLine(n);
//        }
//    }
//}