//Console.WriteLine("Hello World");
//Console.WriteLine("My name is Jumah");

//Variable Declaration(int, double, string, boot)

using System.ComponentModel.Design;

/*int age = 50;
string name = "Jumah";
double height = 34.5;
bool ispresent = false;*/
/////////////////////////
//Console.WriteLine(name + " " + height);
//Console.WriteLine($"{name} {height}");
//Console.WriteLine($"my name  is {name}, i am {age} years old. my height is {height}. are you a christain: {ispresent}");
//Console.WriteLine("my name is " + name + "i am " + age + " years old. my height is " + height + ". are you a christian: " + ispresent);

/*
decimal money = 100.35m;
float temperature = 30.5f;
char grade = 'f';
long pop = 2147483647;
*/

//int , memory 4byte, whole number e.g 10, 20 ,30
//float, memory 4byte, decimal number (less precision) e.g 10.5f, 20.5f
//double, memory 8byte, decimal number e.g 10.564, 15.10
//decimal, memory 16byte, very precise value (money) e.g bank acct number
//long, memory 8byte, very large number e.g 6000000000, 700000000

//mas and nin for -2,147,648 and 2,2147,484,647

//subject: Operator

//  we have four operator : *, +, -, /

//int a = 45;
//int b = 40;
//int addedResult = a + b;
//int subtractResult = a - b;
//int multiplyResult = a * b;
//double divideResult =(double) a / b;
//Console.WriteLine($"Adding a and b value = {addedResult} ");
//Console.WriteLine($"subtracting a and b value = {subtractResult}");
//Console.WriteLine($"multiplying a and b value = {multiplyResult}");
//Console.WriteLine($"dividing a and b value = {divideResult}");

//int pop1 = 200000;
//long pop2 = 9000000000;
//long popResult = pop1 + pop2;
//Console.WriteLine($"population tota1 = {popResult}"); // no precision

//int jumahBalance = 100;
//double sweetPrice = 5.75;
//double jumahamountleft = jumahBalance + sweetPrice;
//Console.WriteLine($"jumah total = {jumahamountleft}"); // no precision

//float value1 = 5.234534635634f;
 //decimal value2 = 2.5m;
 //decimal valueResult = (decimal)value1 + value2;
//float valueResult = value1 + (float)value2;
 //Console.WriteLine($"Lekan said the total value added = {valueResult}");

//double acctbalance = 10.3475;
 //decimal acctbalance2 = 5.20m;
//double acctresult = acctbalance + (double)acctbalance2;
 //Console.WriteLine($"Mariam said the total value added ={acctresult}");
 
 //Easy rules
 //int + long => safe 
 //int + double => safe 
 //float + double => some precision loss
 //double + decimal => conversion need for any variable type we want
//float + decimal => conversion need for any variable type we want
//decimal => best for money
 
//Examples
// int ab = 10;
//int bc = 5;
// int reminder = ab % bc;
//Console.WriteLine($"reminder values = {reminder}");

 //int balance = 5000;
 //int amounttransfered = 3000;
//int newbalance = balance - amounttransfered;      conventional way
//balance -= amounttransfered;                    prefered way
//Console.WriteLine($"New balance = {balance}");

 /*
 int cd = 2;
 int de = 5;
 //int jk = cd * de;  // conventional way
  cd *= de;
 Console.WriteLine($"New balance = {cd}");
 */

 //march 8 2026
//comparism operator
//==, equal to
// !=, not equal to
// >, greater than
// <, less than
// >=, greater than or equal to
// <=, less than or equal to 

//int a = 10;
//int b = 5;
//Console.WriteLine(a > b);// true
//Console.WriteLine(b == a);// false
//Console.WriteLine(a != b);// true

// we make use of if and if-else statement for conditional operator;

//if (a > b)
/*{
 Console.WriteLine("Fatimah is right about a > b to be true");
}
else if (a < b)
{
 Console.WriteLine("Muheeb  was right");
}

else
{
 Console.WriteLine("Tutor said what fatimah said was wrong");
}*/



// Another example 

/*int score = 100;

if (score >= 70)
{
 Console.WriteLine("Grade A");
}
else if (score >= 60)
{
 Console.WriteLine("Grade B");
}
else if (score >= 50)
{
 Console.WriteLine("Grade C");
}
else 
{
 Console.WriteLine("Fail");
}*/

// Logical operators
// && , means "AND" , this binds true and true values
// || , means "OR" , only one has to be true
// ! , means "Not"

// Examples of Logical and comparison operators

// using && 
/*int score = 30;

if (score >= 50 && score <= 100)
{
 Console.WriteLine("Passed");
}
else
{
 Console.WriteLine("failed");
}*/


/*bool paidfees = true;
bool hasIcard = true;
bool hasdonematric = false;

if (paidfees && hasIcard && hasdonematric)
{
 Console.WriteLine("You can enter the exam hall");
}
else
{
 Console.WriteLine("You cannot enter");
}*/




// using ||

/*
bool isStudent = false;
bool isSeniorCitizen = false;

if (isStudent || isSeniorCitizen)
{
 Console.WriteLine("You are qualified for discount");
}
else
{
 Console.WriteLine("You are not qualified for discount");
}
*/


// combining the && and ||


/*bool paidfees = true;
bool hasIcard = true;
bool hasdonematric = false;
bool hasdoneRegistartion = false;
bool isCitizen = false;*/

/*if ((paidfees && hasIcard) || hasdonematric)
{
 Console.WriteLine("Student can enter exam hall");
}
else
{
 Console.WriteLine("Student cannot enter exam hall");
}*/

//2
/*if ((hasdoneRegistartion && paidfees) || isCitizen)
{
 Console.WriteLine("Access Granted");
}
else
{
 Console.WriteLine("Access Denied");
}*/

// 3

/*
if (paidfees && (hasdonematric || hasdoneRegistartion))
{
 Console.WriteLine("Student is fully verified");
}
else
{
 Console.WriteLine("Student is not verified");
}
*/


//4


/*
if ((paidfees && hasIcard) && (hasdonematric || hasdoneRegistartion || isCitizen))
{
 Console.WriteLine("Student cleared");
}
else
{
 Console.WriteLine("Student not cleared");

}*/

//5 

/*
if ((paidfees && hasIcard) && (hasdonematric || hasdoneRegistartion) 
    || (isCitizen && hasIcard))
{
 Console.WriteLine("Student can write the final exam");
}
else
{
 Console.WriteLine("Student cannot write the final exam");
}
*/

// 6

/*if (hasdonematric || paidfees && hasIcard)
{
 Console.WriteLine("Student verified");
}
else
{
 Console.WriteLine("Student not verified");
}*/

// 7

/*if (paidfees && hasIcard && hasdonematric && hasdoneRegistartion)
{
 Console.WriteLine("Student fully cleared");
}
else
{
 Console.WriteLine("Student not fully cleared");
}*/

// 8

/*if (paidfees || hasIcard && hasdonematric || hasdoneRegistartion)
{
 Console.WriteLine("Approved");
}
else
{
 Console.WriteLine("Rejected");
}*/

// 9

/*if (paidfees && hasIcard || hasdonematric || isCitizen)
{
 Console.WriteLine("Student allowed");
}
else
{
 Console.WriteLine("Student not allowed");
}*/

// 10


/*if (paidfees || hasIcard && hasdonematric || hasdoneRegistartion && isCitizen  )
{
 Console.WriteLine("Allowed");
}
else
{
 Console.WriteLine("Not Allowed");
}*/

// 14th - March - 2026
// Operator => !. 

/*bool passedExam = false;
if (!passedExam)
{
 Console.WriteLine("you do not pass the exam");
}
else
{
 Console.WriteLine("you pass the exam");
 
}*/

/*A student can borrow a book only if: - They have paid library fees AND have a valid ID -
 AND they are a staff member AND the book is reserved*/
 

// i want a result where student can borrow
 
/*bool paidFees = true;
bool hasIDCard = true;
bool isStaff = false;
bool bookReserved = false;

bool firstCondition = paidFees && hasIDCard;
bool secondCondition = isStaff  && bookReserved;

if (paidFees && hasIDCard && !isStaff && !bookReserved)
{
 Console.WriteLine("A student can borrow a book");
}
else
{
 Console.WriteLine("A student can not borrow a book");
}*/


/*
int number = 3;

if (number >= 10 && number <= 20)
{
 Console.WriteLine("number is within range");
}
else
{
 Console.WriteLine("number is not within range");
 
}

*/
// LOOPS 
// For-loop,  while-loop, do-while

// a while loop repeats a block of code as long as the condition is true , Example:

/*
while (condition)
{
 run your code 
}
*/

// Compilation Error and Run-Time Error

/*int i = 1;

while (i <= 5)
{
 Console.WriteLine(i);
 i++; // incrementing 
}*/
// 1 ,2 ,3 ,4 ,5
/*this i++ means i = i +1 */



// Do-while
// 1) code run first
//2) then checks the codition if true
// 3) if true, it repeats

/*int i = 1;

do
{
 Console.WriteLine(i);
 i++;
} while (i <= 5);*/

// For Loop
// This is used when you know the number of times you want to loop

/*for (initialization, condition, update)
{
  code to run
}*/

/*for (int i = 1; i <= 5; i++)
{
 Console.WriteLine(i);
}*/


//For Barakah, Lekan , jumah use while loop to print 35-77 
//for ademola and mariam use do-while to print 99-107
// for Muheeb and fatimah use for loop to print 125-176

// Print even numbers from 1 to 20
/*for (int i = 0; i < 20; i++)
{
 if (i % 2 != 0)
 {
  Console.WriteLine(i);
 }
}*/

//Arrays 
// Arrays is used to store multiple variables of same data type in one variable 

/*int num1 = 10;
int num2 = 20;
int num3 = 30;*/

//int[] numbers = { 10, 20, 30 }; // array of numbers 

/*
for (int i = 0; i < numbers.Length; i++)
{
 Console.WriteLine(numbers[i]);
}
*/

/*
string student1 = "Lekan";
string student2 = "Mariam";
string student3 = "Jumah";

string[] students = { "lekan", "mariam", "muheeb", "fatimah", "Pedro", "barakah" };*/ // Array of students

//Console.WriteLine($"Fatimah name to be printed\n..Printout result= {students[3]}"); // fatimah
//Console.WriteLine($"Pedro name to be printed\n..Printout result= {students[4]}"); // pedro


// indexing starts from 0 
// Length starts from 1




 
//Console.WriteLine(students.Length); this prints the lenght of the students 

/*
for (int i = 0; i < students.Length; i++)
{
 Console.WriteLine( students[i]);
}
*/

// Formatting to have student number 

//Console.WriteLine(students.Length); this prints the lenght of the students 

/*for (int i = 0; i < students.Length; i++)
{
 Console.WriteLine($"Student{i + 1} : {students[i]}");
}*/

// we acheived
/*Student1 : lekan
Student2 : mariam
Student3 : muheeb
Student4 : fatimah
Student5 : Pedro
Student6 : barakah*/




//int[] numbers = { 10, 20, 30 }; // array of numbers 

/*
for (int i = 0; i < numbers.Length; i++)
{
 Console.WriteLine(numbers[i]);
}
*/

// 10
// 20
// 30
// 40


// Using loop to Add numbers together

/*int[] numbers = { 10, 20, 30, 40 }; // array of numbers 

int sum = 0; // base number we want to use to perform add operation

for (int i = 0; i < numbers.Length; i++)
{
    sum = sum + numbers[i];
    sum += numbers[i]
    // sum = 0 + (numbers[0]) 10 = 10 
    // sum = 10 + (numbers[1]) 20 = 30
    // sum = 30 + (number[2]) 30 = 60
    // sum = 60 + (number[3]) 40 = 100
    // sum = 100
    
}

Console.WriteLine($"Sum of all the numbers = {sum}");*/

// Using Loop to multiply together
/*int[] numb = { 2, 3, 4, 5, 6 };

int mult = 1;

for (int i = 0; i < numb.Length; i++)
{
  mult = mult * numb[i];
}
Console.WriteLine($"Multiplication of all the numbers = {mult}");*/


// Lets Build Multiplication table 

/*int multiplicationTable = 6;

for (int i = 1; i <= 12; i++)
{
 Console.WriteLine($"{multiplicationTable} X {i} = {multiplicationTable * i}");
}*/

// 2 X 1 = 2
// 2 X 2 = 4


