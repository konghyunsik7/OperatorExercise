using OperatorExcerise;

//Excerise1

double x = 15;
double y = 30;

x += y;
x -= y;
x /= y;
x *= y;
x %= y;



int a = 17;
int b = 4;
int quotient = a / b;
int remainder = a % b;

Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");



//Exercise2


Console.WriteLine("What is the radius of your circle?");

var stansVariable = double.Parse(Console.ReadLine());

Console.WriteLine($"The area of a circle with radius of {stansVariable} is {Methods.AreaOfCircle(stansVariable)}");








