// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Enter 2 numbers");

int num1, num2, ans;

num1=Convert.ToInt32(Console.ReadLine());
num2 = Convert.ToInt32(Console.ReadLine());


ans = num1 + num2;
Console.WriteLine(ans);

string? s1="";
string? s2="";

string s3;
s1 = Console.ReadLine();
s2=Console.ReadLine();

s3 = s1 + " " + s2;
Console.WriteLine(s3);

Console.WriteLine(s1.Equals(s2));
Console.WriteLine(s1.ToUpper());
Console.WriteLine(s1.ToLower());

Console.WriteLine(s2.Substring(3));
string[] s=s3.Split(' ');
for(int i=0; i<s.Length;i++)
Console.WriteLine(s);*/

/*char x ='5';
switch (x)
{
    case '1':
        Console.WriteLine();
        break;

    case '2':
        Console.WriteLine();
        break;

    case '3':
        Console.WriteLine();
        break;

    default:Console.WriteLine();
        break;
}*/
//driver
using basic_program;

int consumernumber = Convert.ToInt32(Console.ReadLine());
Electricity electricity1 = new Electricity(consumernumber,9000,9300,"aa");
Console.WriteLine(electricity1.consumernumber);
Console.WriteLine(electricity1.consumername);
Console.WriteLine(electricity1.CalculateBill);
Electricity electricity2 = new Electricity(123456, 9000, 1000, "aa");
Console.WriteLine(electricity2.consumernumber);
Console.WriteLine(electricity2.consumername);
Console.WriteLine(electricity2.CalculateBill);

//double billamount = electricity = electricity.CalculateBill();



/*Calculation calculation = new Calculation();
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

double res = calculation.Add(num1 + num2);
Console.WriteLine(res);*/


