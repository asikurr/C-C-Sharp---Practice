// See https://aka.ms/new-console-template for more information

int num = int.Parse(Console.ReadLine());
for (int i = 1; i <= num; i++)
{
    string n = Console.ReadLine().ToLower();
    if (n.Length >= 1 && n.Length <= 100)
    {
        if (n.Length >= 11)
        {
            string fistIndex = n.Substring(0, 1);
            int countVal = n.Length - 2;
            string lastIndex = n.Substring(n.Length - 1);
            Console.WriteLine("{0}{1}{2}", fistIndex, countVal, lastIndex);
        }
        else
        {
            Console.WriteLine(n);
        }
    }
}