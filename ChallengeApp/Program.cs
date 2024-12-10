using System.Xml;

int number = 4566;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();
Console.WriteLine("Wyniki dla liczby" + number);

int c0 = 0;
int c1 = 0;
int c2 = 0;
int c3 = 0;
int c4 = 0;
int c5 = 0;
int c6 = 0;
int c7 = 0;
int c8 = 0;
int c9 = 0;

foreach (char c in letters)
{
    if (c == '0')
    {
        c0++;
    }
    else if (c == '1')
    {
        c1++;
    }
    else if (c == '2')
    {
        c2++;
    }
    else if (c == '3')
    {
        c3++;
    }
    else if (c == '4')
    {
        c4++;
    }
    else if (c == '5')
    {
        c5++;
    }
    else if (c == '6')
    {
        c6++;
    }
    else if (c == '7')
    {
        c7++;
    }
    else if (c == '8')
    {
        c8++;
    }
    else if (c == '9')
    {
        c9++;
    }


}
Console.WriteLine("0=>" + c0);
Console.WriteLine("1=>" + c1);
Console.WriteLine("2=>" + c2);
Console.WriteLine("3=>" + c3);
Console.WriteLine("4=>" + c4);
Console.WriteLine("5=>" + c5);
Console.WriteLine("6=>" + c6);
Console.WriteLine("7=>" + c7);
Console.WriteLine("8=>" + c8);
Console.WriteLine("9=>" + c9);


