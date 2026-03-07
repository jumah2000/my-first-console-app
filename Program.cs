//Console.WriteLine("Hello World");
//Console.WriteLine("My name is Jumah");

//Variable Declaration(int, double, string, boot)

int age = 50;
string name = "Jumah";
double height = 34.5;
bool ispresent = false;
/////////////////////////
//Console.WriteLine(name + " " + height);
//Console.WriteLine($"{name} {height}");
//Console.WriteLine($"my name  is {name}, i am {age} years old. my height is {height}. are you a christain: {ispresent}");
//Console.WriteLine("my name is " + name + "i am " + age + " years old. my height is " + height + ". are you a christian: " + ispresent);

decimal money = 100.35m;
float temperature = 30.5f;
char grade = 'f';
long pop = 2147483647;

//int , memory 4byte, whole number e.g 10, 20 ,30
//float, memory 4byte, decimal number (less precision) e.g 10.5f, 20.5f
//double, memory 8byte, decimal number e.g 10.564, 15.10
//decimal, memory 16byte, very precise value (money) e.g bank acct number
//long, memory 8byte, very large number e.g 6000000000, 700000000

//mas and nin for -2,147,648 and 2,2147,484,647

//subject: Operator

//  we have four operator : *, +, -, /

int a = 45;
int b = 40;
int addedResult = a + b;
int subtractResult = a - b;
int multiplyResult = a * b;
double divideResult =(double) a / b;
//Console.WriteLine($"Adding a and b value = {addedResult} ");
//Console.WriteLine($"subtracting a and b value = {subtractResult}");
//Console.WriteLine($"multiplying a and b value = {multiplyResult}");
//Console.WriteLine($"dividing a and b value = {divideResult}");

int pop1 = 200000;
long pop2 = 9000000000;
long popResult = pop1 + pop2;
//Console.WriteLine($"population tota1 = {popResult}"); // no precision

int jumahBalance = 100;
double sweetPrice = 5.75;
double jumahamountleft = jumahBalance + sweetPrice;
//Console.WriteLine($"jumah total = {jumahamountleft}"); // no precision

float value1 = 5.234534635634f;
 decimal value2 = 2.5m;
 //decimal valueResult = (decimal)value1 + value2;
float valueResult = value1 + (float)value2;
 //Console.WriteLine($"Lekan said the total value added = {valueResult}");
 
 double acctbalance = 10.3475;
 decimal acctbalance2 = 5.20m;
double acctresult = acctbalance + (double)acctbalance2;
 //Console.WriteLine($"Mariam said the total value added ={acctresult}");
 
 //Easy rules
 //int + long => safe 
 //int + double => safe 
 //float + double => some precision loss
 //double + decimal => conversion need for any variable type we want
//float + decimal => conversion need for any variable type we want
//decimal => best for money
 
 //Examples
 int ab = 10;
 int bc = 5;
 int reminder = ab % bc;
Console.WriteLine($"reminder values = {reminder}");
 