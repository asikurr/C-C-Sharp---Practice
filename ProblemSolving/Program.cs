// Problem Solving 
//A. Even Odds
using System.Collections.Generic;
//A. Ultra-Fast Mathematician
string n = Console.ReadLine();
string m = Console.ReadLine();
string result = "";
for (int i = 0; i < n.Length; i++)
{
	if (n[i] == m[i])
	{
		result = result + 0;
	}
	else
	{
		result = result + 1;
	}
}
Console.WriteLine(result);

//--------------------------------------------

//var input = Console.ReadLine().Split();
//var n = Convert.ToInt64(input[0]);
//var k = Convert.ToInt64(input[1]);
//var c = 0L;

//if (n % 2 == 0)
//{
//    c = n / 2;
//}
//else
//{
//    c = (n + 1) / 2;
//}
//if (k <= c)
//{
//    Console.WriteLine((k * 2) - 1);
//}

//else
//{
//    Console.WriteLine((k - c) * 2);
//}

//-----------------------------------------------

//A. Magnets
//int n = int.Parse(Console.ReadLine()!);
//int a, b = 0, k = 0;
//for (int i = 0; i < n; i++)
//{
//    a = int.Parse(Console.ReadLine()!);

//    if (a != b)
//        k++;
//    b = a;
//}
//Console.WriteLine(k);

////---------------------------------------------

////A. Presents
////int n = int.Parse(Console.ReadLine());
//int[] p = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//string values = "";
//int v = 1;

//for (int i = 0; i < p.Length; i++)
//{
//   if( p[i] == v)
//    {
//        values += i+1 + " ";
//        if( v == p.Length) { Console.WriteLine(values.Trim()); return; }
//        v++;
//        i = -1;
//    }
//}

//-----------------------------------------------

//A.George and Accommodation
//int n = int.Parse(Console.ReadLine());
//string[] p;
//int count = 0;
//for (int i = 0; i < n; i++)
//{
//    p = Console.ReadLine().Split(" ");
//    if ((int.Parse(p[0]) < int.Parse(p[1])) && (int.Parse(p[0])+1 < int.Parse(p[1])))
//    {
//        count = count + 1;
//    }
//}
//Console.WriteLine(count);

//--------------------------------------------------

//A. Twins
//int n = int.Parse(Console.ReadLine());
//int[] arr= new int[n];
//int j = 0;
//foreach (string s in Console.ReadLine().Split(" "))
//{
//    arr[j] = int.Parse(s);
//    j++;
//}
//int total = 0;
//int half = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    total+= arr[i];
//}
//half = total / 2;
//int count = 0;
//Array.Sort(arr);
//int sum2 = 0;
//for (int i = arr.Length - 1; i >= 0; i--)
//{
//    sum2 += arr[i];
//    count = count + 1;
//    if (sum2 > half)
//    {
//        Console.WriteLine(count);
//        return;
//    }
//}




//---------------------------------------------------

//A. Nearly Lucky Number
//string number = Console.ReadLine();
//char[] arry = number.ToString().ToArray();
//int count = 0;
//for (int i = 0;i < arry.Length; i++)
//{
//	if (arry[i] == '4' || arry[i] =='7')
//	{
//		count += 1;
//	}
//}
//if (count == 4|| count == 7)
//{
//	Console.WriteLine("YES");
//}
//else
//{
//    Console.WriteLine("NO");
//}

//-----------------------------------------------

//A. Lucky Division
//int n = int.Parse(Console.ReadLine());
//int firstLucy = 4;
//int secendLucy = 7;
//if( n % 4 == 0 || n % 7 == 0 || n % 44 == 0 || n % 77 == 0 || n % 47 == 0 || n % 74 == 0 ||
//    n % 444 == 0 || n % 447 == 0 || n % 474 == 0 || n % 744 == 0 || n % 777 == 0 || n % 747 == 0 ||
//    n % 477 == 0 || n % 774 == 0
//    )
//{
//    Console.WriteLine("YES");
//}else
//{
//    Console.WriteLine("NO");
//}

//-------------------------------------------------------

//matrix imput
//int n = int.Parse(Console.ReadLine());

//int[,] arr = new int[n,n];
//int i = 0;
//int j = 0;
//for (i = 0; i < n; i++)
//{
//    j = 0;
//    foreach (string s in Console.ReadLine().Split(" "))
//    {
//        arr[i, j] = int.Parse(s);
//        j++;
//    }
//}

//--------------------------------------------------------

//int n = int.Parse(Console.ReadLine());
//int[] arr = new int[n];
//int i = 0;
//foreach (string s in Console.ReadLine().Split(" "))
//{
//    arr[i] = int.Parse(s);
//    i++;
//}
//Array.Sort(arr);
//if (arr[arr.Length - 1] == 1)
//{
//    Console.WriteLine("HARD");
//}
//else
//{
//    Console.WriteLine("EASY");
//}



//a. In Search of an Easy Problem
//int n = int.Parse(Console.ReadLine());
//int[] arr = new int[n];
//for (int i = 0;i < n; i++)
//{
//    arr[i] = int.Parse(Console.ReadLine());
//}
//Array.Sort(arr);
//if (arr[arr.Length-1] == 1)
//{
//    Console.WriteLine("HARD");
//}
//else
//{
//    Console.WriteLine("EASY");
//}


//A. Beautyful Year
//int n = int.Parse(Console.ReadLine());
//for (int i = 1001;i<9000; i++)
//{
//    n++;
//    int first = n / 1000;
//    int Second = (n / 100) % 10;
//    int third = (n / 10) % 10;
//    int four = n % 10;
//    if(!(first == Second || first == third || first == four || Second == third || Second == four || third == four))
//    {
//        Console.WriteLine(n);
//        break;
//    }
//}

//-------------------------------------------------------------

//A.Hulk
//int n = int.Parse(Console.ReadLine());
//string hulkBehave = "";
//for (int i = 1; i <= n; i++)
//{

//    if(i % 2 != 0)
//    {
//        if (i == 1 && n == 1)
//        {
//            hulkBehave += "I hate it";
//        }else if(i == n)
//        {
//            hulkBehave += "I hate it";
//        }
//        else
//        {
//            hulkBehave += "I hate that ";
//        }

//    }
//    else
//    {
//        if (i == 2 && n == 2)
//        {
//            hulkBehave += "I love it";
//        }
//        else if (i == n)
//        {
//            hulkBehave += "I love it";
//        }
//        else
//        {
//            hulkBehave += "I love that ";
//        }
//    }
//}
//Console.WriteLine(hulkBehave);

//-----------------------------------------------

//A. HQ9+
//string s = Console.ReadLine();
//char[] val = s.ToCharArray();
//string result = "";
//for (int i = 0; i < val.Length; i++)
//{
//    if (char.Equals(val[i], 'H') || char.Equals(val[i], 'Q') || char.Equals(val[i], '9'))
//    {
//        result = "YES";
//        break;
//    }
//}
//if (result == "YES")
//{
//    Console.WriteLine("YES");
//}
//else
//{
//    Console.WriteLine("NO");
//}

//--------------------------------------------------------------

//A. Chat room //ahhellllloou//hlelo//tymbzjyqhymedasloqbq
//string s = Console.ReadLine();
//char[] sArray = s.ToCharArray();
//char[] helloStr = new char[] { 'h', 'e', 'l', 'l', 'o' };
//string helloVal = "";
//for(int i = 0;i < helloStr.Length; i++)
//{
//    for (int j = 0; j <sArray.Length; j++)
//    {
//        if (i > 4)
//        {
//            break;
//        }
//        else
//        {
//            if (char.Equals(helloStr[i], sArray[j]))
//            {
//                helloVal = helloVal + helloStr[i];
//                i++;
//                if (helloVal == "hello")
//                {
//                    break;
//                }
//            }
//        }

//    }
//}
//if (helloVal == "hello")
//{
//    Console.WriteLine("YES");
//}
//else
//{
//    Console.WriteLine("NO");
//}

//---------------------------------------------------

//A. Tram
//using System;
//int n  = int.Parse(Console.ReadLine());
//int[][] jagar = new int[n][];
//int i = 0;
//while (i < n)
//{
//    string val = Console.ReadLine();
//    string[] intVal = val.Split(" ");
//    jagar[i] = intVal.Select(int.Parse).ToArray(); ;
//    i++;
//}
//int capacity = 0;
//int capacityMax = 0;
//for(int p=0; p<n; p++)
//{
//        capacityMax = capacityMax + 0;
//        capacity = capacity - jagar[p][0];
//        capacity = capacity + jagar[p][1];
//        capacityMax = Math.Max(capacityMax, capacity);
//}
//Console.WriteLine(capacityMax);

//-------------------------------------------

//A. Word
//string s = Console.ReadLine();
//char[] charVal = s.ToCharArray();
//int upperCount = 0;
//for (int i = 0;i < charVal.Length; i++)
//{
//    if (char.IsUpper(charVal[i]))
//    {
//        upperCount = upperCount + 1;
//    }
//}
//if(upperCount > (charVal.Length - upperCount))
//{
//    Console.WriteLine(s.ToUpper());
//}
//else
//{
//    Console.WriteLine(s.ToLower());
//}

//---------------------------------------------------

//A. Elephant
//int n =int.Parse(Console.ReadLine());
//int m = 0;
//if (n <= 5)
//{
//    Console.WriteLine(1);
//}
//else
//{
//    m = n % 5;
//    n = n / 5;
//    if (m == 0)
//    {
//        Console.WriteLine(n);
//    }else { 
//        Console.WriteLine(n+1); 
//    }
//}

//--------------------------------------------------------------

//A. Wrong Subtraction
//string val = Console.ReadLine();
//string[] valArr = val.Split(' ');
//int[] values = valArr.Select(int.Parse).ToArray();
//int n = values[0];
//int k = values[1];
//for (int i = 1; i <= k; i++)
//{

//    if (n % 10 == 0)
//    {
//        n = n / 10;
//    }
//    else
//    {
//        n = n - 1;
//    }
//}
//Console.WriteLine(n);

//--------------------------------------------------------

//A. Bear and Big Brother
//string val = Console.ReadLine();
//string[] valArr = val.Split(' ');
//int[] values = valArr.Select(int.Parse).ToArray();
//int year = 0;
//int limantYear = values[0];
//int bobyear = values[1];

//while (!(limantYear > bobyear))
//{
//    year = year + 1;
//    limantYear = limantYear * 3;
//    bobyear = bobyear * 2;

//    if (limantYear > bobyear)
//    {
//        Console.WriteLine(year);
//        break;
//    }
//}

//-----------------------------------------------

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

//----------------------------------------------

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

//------------------------------------------------------

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

//-------------------------------------------------

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

//----------------------------------------------


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

//-----------------------------------------------

//A. Word Capitalization
//using System.Collections.Generic;
//string inpVal = Console.ReadLine();
//if (!Char.IsUpper(inpVal , 0))
//{
//   char first =  Char.ToUpper(inpVal[0]);
//   Console.WriteLine(first+ inpVal.Substring(1,inpVal.Length - 1));
//}
//else { Console.WriteLine(inpVal); }

//----------------------------------------------------

//A. Helpful Maths
//string s = Console.ReadLine();
//string[] str = s.Split('+');
//int[] num = str.Select(int.Parse).ToArray();
//Array.Sort(num);

//string value = "";
//for (int i = 0; i < num.Length; i++)
//{
//    value = value + num[i] + "+";
//}
//string x = value.Substring(0, value.Length - 1);
//Console.Write(x);

//---------------------------------------------------------

//A.Petya and Strings
//string firstString = Console.ReadLine().ToLower();
//string SecountString = Console.ReadLine().ToLower();
//if (string.Equals(firstString, SecountString))
//{
//    Console.WriteLine(string.Compare(firstString, SecountString));
//}
//else if (string.Compare(firstString, SecountString) < 1)
//{
//    Console.WriteLine(string.Compare(firstString, SecountString));
//}
//else if (string.Compare(firstString, SecountString) > 0)
//{
//    Console.WriteLine(string.Compare(firstString, SecountString));
//}

//---------------------------------------------------

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
//=========================
//int z = 0; int g = 0;

//for (int i = 0; i < 5; i++)
//{
//    string x = Console.ReadLine().Trim();
//    string[] y = x.Split(" ");


//    for (int j = 0; j < 5; j++)
//    {
//        g = int.Parse(y[j]);

//        if (g == 1) { z = Math.Abs(i - 2) + Math.Abs(j - 2); }
//    }
//}
//Console.WriteLine(z);
//=========================
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