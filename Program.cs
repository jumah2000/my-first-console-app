//Task 1- Arithmetic Operators

//int a = 60;
//int b = 25;
//int addedResult = a + b;
//int subtractionResult = a - b;
//int multiplicationResult = a * b;
//double divisionResult = (double)a / b;
//int modulusResult = a % b;
//Console.WriteLine($"adding a and b value = {addedResult}");
//Console.WriteLine($"subtracting a and b value = {subtractionResult}");
//Console.WriteLine($"multiplying a and b value = {multiplicationResult}");
//Console.WriteLine($"dividing a and b value = {divisionResult}");
//Console.WriteLine($"modulus a and b value = {modulusResult}");

//Task 2- Integer vs Double
int a = 10;
int b = 4;
int integerDivisionResult = a / b;
double doubleDivisionResult = (double)a/b;
Console.WriteLine($"Dividing a and b value = {integerDivisionResult} integer division result");
Console.WriteLine($"Dividing a and b value = {doubleDivisionResult} double division result");

//Task 3- Large Numbers
long pop = 90000000;
int increase = 250000;
long newPopResult = pop + increase;
Console.WriteLine($"Adding population and increasing it = {newPopResult} new population");

//Task 4 - shop Calculator 
decimal price = 1500.75m;
int quantity = 3;
decimal totalPriceResult= price * quantity;
Console.WriteLine($"Total price = {totalPriceResult}");

//Task 5 - Bonus Challenge
int num1 = 50;
int num2 = 10;
int num3 = 5;
 double averageResult = (num1 + num2 + num3) /3.0;
 Console.WriteLine($"Average result: {averageResult}");