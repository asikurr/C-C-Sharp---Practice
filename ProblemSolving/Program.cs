// Problem Solving 

//A. Bear and Big Brother
string val = Console.ReadLine();
string[] valArr = val.Split(' ');
int[] values = valArr.Select(int.Parse).ToArray();
int year = 0;
int limantYear = values[0];
int bobyear = values[1];

while (!(limantYear > bobyear))
{
    year = year + 1;
    limantYear = limantYear * 3;
    bobyear = bobyear * 2;

    if (limantYear > bobyear)
    {
        Console.WriteLine(year);
        break;
    }
}





//A. Soldier and Bananas
//string val = Console.ReadLine();
//string[] valArr = val.Split(' ');
//int[] values = valArr.Select(int.Parse).ToArray();
//int k = values[0];
//int n = values[1];
//int w = values[2];
//int totalDollar = 0;
//int dollars = 0;
//for (int i = 1; i <= w ; i++)
//{
//    dollars = k * i;
//    totalDollar = totalDollar + dollars;
//}
//int money = totalDollar - n;
//if (money < 0)
//{
//    Console.WriteLine(0);
//}
//else
//{
//    Console.WriteLine(money);
//}



//A Football 100001000000110101100000
//string player = Console.ReadLine();
//char[] pNum = player.ToCharArray();
//int num = 0;
//int j = 0;
//for (int i = 0;i < pNum.Length; i++)
//{
//	if (char.Equals(pNum[i], pNum.Length -1 == i? null : pNum[j=j+1] ))
//	{
//		num = num + 1;
//	}
//	else
//	{
//		if (num < 6)
//		{
//			num = 0;
//		}
//	}
//}
//if (num+1 >= 7)
//{
//	Console.WriteLine("YES");
//}
//else
//{
//    Console.WriteLine("NO");
//}








//A. Stones on the Table
//int n = int.Parse(Console.ReadLine());
//string S = "";
//for (int i = 0; i < n; i++)
//{
//    S += Console.ReadLine();
//}
//char[] sValue = S.ToCharArray();
//int num = 0;
//int val = 0;
//int cnt = sValue.Length;
//for (int j = 0; j< sValue.Length; j++)
//{
//    if(sValue.Length > 1)
//    {
//        if (char.Equals(sValue[j], j == cnt - 1 ? null : sValue[val += 1]))
//        {
//            num = num + 1;
//        }
//    }
//}
//Console.WriteLine(num);





//A. Boy or Girl
//string inputVal = Console.ReadLine();
//var inValue = new HashSet<char>(inputVal);
//int valLenght = inValue.Count;
//if (valLenght % 2 == 0)
//{
//    Console.WriteLine("CHAT WITH HER!"); 
//}
//else
//{
//    Console.WriteLine("IGNORE HIM!");
//}

//A. String Task
//char[] inputVal = Console.ReadLine().ToUpper().ToCharArray();
//string val = "";
//foreach (char c in inputVal)
//{
//    if (!(char.Equals(c, 'A') || char.Equals(c, 'E') || char.Equals(c, 'I') || char.Equals(c, 'O') || char.Equals(c, 'U') || char.Equals(c, 'Y')))
//    {
//        val = val + "." + c;
//    }
//}
//Console.Write(val.ToLower());


//A. Word Capitalization
//using System.Collections.Generic;
//string inpVal = Console.ReadLine();
//if (!Char.IsUpper(inpVal , 0))
//{
//   char first =  Char.ToUpper(inpVal[0]);
//   Console.WriteLine(first+ inpVal.Substring(1,inpVal.Length - 1));
//}
//else { Console.WriteLine(inpVal); }


//A. Helpful Maths
//string s = Console.ReadLine();
//string[] str = s.Split('+');
//int[] num = str.Select(int.Parse).ToArray();
//Array.Sort(num);

//string value= "";
//for (int i = 0; i < num.Length; i++)
//{
//   value = value + num[i]+ "+";
//}
//string x = value.Substring(0, value.Length - 1);
//Console.Write(x);



//A.Petya and Strings
//string firstString = Console.ReadLine().ToLower();
//string SecountString = Console.ReadLine().ToLower();
//if (string.Equals(firstString, SecountString))
//{
//    Console.WriteLine(string.Compare(firstString, SecountString));
//}else if (string.Compare(firstString, SecountString) < 1)
//{
//    Console.WriteLine(string.Compare(firstString, SecountString));
//}else if(string.Compare(firstString, SecountString) > 0)
//{
//    Console.WriteLine(string.Compare(firstString, SecountString));
//}




//A. Domino Piling
//string mn = Console.ReadLine();
//string[] valueMn = mn.Split(" ");
//int[] mAndnSize =  valueMn.Select(int.Parse).ToArray();
//int mnSize = (mAndnSize[0] * mAndnSize[1])/2;
//Console.WriteLine(mnSize);

//Bit++
//int X = 0;
//string inpVal;
//int n = int.Parse(Console.ReadLine());
//for (int i = 0;i < n; i++)
//{
//    inpVal = Console.ReadLine();
//    if(inpVal == "++X"|| inpVal == "X++")
//    {
//        X++; 
//    }else if(inpVal == "--X" || inpVal == "X--")
//    {
//        --X;
//    }
//}
//Console.WriteLine(X);

//--------------------------------

//Beautiful Matrix
//{{0,0,0,0,0 },
//{0,0,0,0,0 },
//{0,0,1,0,0 },
//{0,0,0,0,0 },
//{0,0,0,0,0 }};
//int[][] jagar = new int[5][];
//int i = 0;
//while (i < 5)
//{
//    string val = Console.ReadLine();
//    string[] intVal = val.Split(" ");
//    jagar[i] = intVal.Select(int.Parse).ToArray(); ;
//    i++;
//}
//for(int k = 0; k < 5; k++)
//{
//    for(int j=0; j<5; j++)
//    {
//        if (jagar[k][j] == 1)
//        {
//            Console.WriteLine(Math.Abs(k - 2) + Math.Abs(j - 2));
//        }
//    }
//}

// --------------------------------------
//Team
//int n = int.Parse(Console.ReadLine());
//int[][] jagar= new int[n][];
//int i = 0;
//while (i < n)
//{
//    string val = Console.ReadLine();
//    string[] intVal = val.Split(" ");
//    jagar[i] = intVal.Select(int.Parse).ToArray(); ;
//    i++;
//}


//int views = 0;
//for (int j = 0; j < n; j++)
//{

//    int count = 0;
//    for (int k = 0; k < jagar[j].Length; k++)
//        {
//        if (count == 2)
//        {
//            count = 0;
//        }
//        if (jagar[j][k] == 1 )
//        {
//            count += 1;

//        }
//        if (count >= 2) {
//            views = views + 1;
//        }

//        }

//}
//Console.WriteLine(views);


//----------------------------------------------

//Way Too Long Words
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