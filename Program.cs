// See https://aka.ms/new-console-template for more information

//1
// 1) კომპილაცია;
// 2) CIL(Common Intermediate Language);
// 3) CLR(Common Language Runtime);
// 4) მანქანური კოდი

// 2
double num1;
if (!double.TryParse(Console.ReadLine(), out num1))
    Console.WriteLine("Invalid value entered");
double num2;
if (!double.TryParse(Console.ReadLine(), out num2))
    Console.WriteLine("Invalid value entered");

double Sum(double number1, double number2)
{
    double total;
    total = number1 + number2;
    return total;

}

double Dif(double number1, double number2)
{
    double total;
    total = number1 - number2;
    return total;

}

double prod(double number1, double number2)
{
    double total;
    total = number1 * number2;
    return total;

}
Console.WriteLine("\nThe sum of two numbers is : {0} \n", Sum(num1, num2));
Console.WriteLine("\nThe difference between two numbers is : {0} \n", Dif(num1, num2));
Console.WriteLine("\nThe product of two numbers is : {0} \n", prod(num1, num2));


// 3
int height;
if (!int.TryParse(Console.ReadLine(), out height))
    Console.WriteLine("Invalid value entered");
int length;
if (!int.TryParse(Console.ReadLine(), out length))
    Console.WriteLine("Invalid value entered");

int area(int height, int length)
{
    int ar;
    ar = height * length;
    return ar;

}

int per(int height, int length)
{
    int total;
    total = (height + length) * 2;
    return total;

}

Console.WriteLine(area(height, length));
Console.WriteLine(per(height, length));

// 4
int a;
if (!int.TryParse(Console.ReadLine(), out a))
    Console.WriteLine("Invalid value entered");
int b;
if (!int.TryParse(Console.ReadLine(), out b))
    Console.WriteLine("Invalid value entered");
int c;
if (!int.TryParse(Console.ReadLine(), out c))
    Console.WriteLine("Invalid value entered");

int min = a;
int mid = b;
int max = c;
if (min > mid) { mid = a; min = b; }
if (mid > max)
{
    max = mid;
    mid = c;
    if (min > mid)
    {
        mid = min;
        min = c;
    }
}

//5
int num;
if (!int.TryParse(Console.ReadLine(), out num))
    Console.WriteLine("Invalid value entered");
int n = num % 10;
while (num != 0) 
{
    Console.WriteLine(n);
    num = num/10;
}