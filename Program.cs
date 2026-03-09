// Challenge 1- Multi-Condition Exam Eligibility

/*
bool paidFees = true;
bool hasIdCard = true;
bool hasDoneMatric = false;
bool isCitizen = false;

if (paidFees && hasIdCard || hasDoneMatric || isCitizen)
{
    Console.WriteLine("A student can take the final exam");
}
else
{
    Console.WriteLine("A student can not take the final exam");
}
*/

//Step 1: paidFees && hasIdCard => This is a true and true value
// true && true = true
//so now the expression becomes:
//true || false || false

//Step 2: true || false => Only one has to be true
// true || false = true
//now the expression becomes:
//true || false

//Step 3: true || false = true

//THE FINAL ANSWER IS TRUE (THE STUDENT CAN TAKE THE FINAL EXAM)


//Challenge 2- Access to School Portal

/*bool paidFees =  false;
bool hasIdCard = true;
bool hasDoneRegistration = true;
bool isCitizen = false;

if (hasDoneRegistration && paidFees || isCitizen && hasIdCard)
{
    Console.WriteLine("A student can access the school portal");
}
else
{
    Console.WriteLine("A student can not access the school portal");
}*/

//Step 1: hasDoneRegistration && paidFees 
//true && false = false
// so the expression becomes: 
// false || (isCitizen && hasIdCard)

//Step 2: isCitizen && hasIdCard
//false && true = false
//now the expression becomes:
//false || false

//Step 3: false || false = false

// THE FINAL OUTPUT(ANSWER) IS FALSE =>THE STUDENT CANNOT ACCESS THE SCHOOL PORTAL
// NOTE: Both required condition groups are false, so access is denied.


//Challenge 3- Grading System

int score = 45;
if (score >= 80)
{
    Console.WriteLine("Grade A");
}
else if (score >= 60 && score < 80)
{
    Console.WriteLine("Grade B");
}
else if (score >= 50 && score < 60)
{
    Console.WriteLine("Grade C");
}
else
{
    Console.WriteLine("Grade: Fail");
}
score = 55;
if (score >= 80)
{
    Console.WriteLine("Grade A");
}
else if (score >= 60 && score < 80)
{
    Console.WriteLine("Grade B");
}
else if (score >= 50 && score < 60)
{
    Console.WriteLine("Grade C");
}
else
{
    Console.WriteLine("Grade: Fail");
}
score = 65;
if (score >= 80)
{
    Console.WriteLine("Grade A");
}
else if (score >= 60 && score < 80)
{
    Console.WriteLine("Grade B");
}
else if (score >= 50 && score < 60)
{
    Console.WriteLine("Grade C");
}
else
{
    Console.WriteLine("Grade: Fail");
}
score = 85;
if (score >= 80)
{
    Console.WriteLine("Grade A");
}
else if (score >= 60 && score < 80)
{
    Console.WriteLine("Grade B");
}
else if (score >= 50 && score < 60)
{
    Console.WriteLine("Grade C");
}
else
{
    Console.WriteLine("Grade: Fail");
}

//Explanation of each score 
//score = 45 is less than 50
// it does not satisfy any of the condition // therefore the else block runs
// output is FAIL

//Score = 55 is less than 60
//it satisfies the condition score >= 50 && score < 60
// output: Grade C

//Score = 65 is greater than or equal to 60  // 65 is less than 80
//it satisfies the condition score >= 60 && score < 80
// output: Grade B 

//Score = 85 is greater than or equal to 80
//it satisfies the first condition
// output: Grade A


//Challenge 4- Library Borrowing Rules 

/*bool paidFees = true;
bool hasIdCard = true;
bool isStaff = false;
bool bookReserved = false;

if (paidFees && hasIdCard || isStaff && bookReserved)
{
    Console.WriteLine("A student can borrow a book");
}
else
{
    Console.WriteLine("A student can not borrow a book");
}*/

//Step 1:first condition
//paidFees && hasIdCard
// true && true = true

//Step 2: Second condition
// isStaff && bookReserved
//false && false = false

//Step 3: true || false = true

// the final answer is TRUE (A student can borrow a book)
//NOTE: Since one condition is true, the final result becomes true


//Challenge 5- Complex 5-Variable Logic
bool paidFees = true;
bool hasIdCard = true;
bool hasDoneMatric = false;
bool hasDoneRegistration = false;
bool isCitizen = false;

if (paidFees && hasIdCard && hasDoneMatric || hasDoneRegistration || isCitizen && hasIdCard)
{
  Console.WriteLine("A student is fully verified for all school processes");  
}
else
{
    Console.WriteLine("A student is not fully verified for all school processes");
}

// EVALUATE ALL AND OPERATION
//Step 1:paidFees && hasIdCard
//true && true = true
//Expression becomes:
// true || false || false || false || true

// Step 2: true && hasDoneMatric
// true && false = false
//Expression becomes:
// false || false || false && true

// Step 3:false && hasIdCard 
//false && true = false
//Expression becomes:
//false || false || false

// EVALUATE OR OPERATION
//Step 4: false || hasDoneRegistration
//false || false = false
//Expression becomes:
//false || false 

//Step 5: false ||  isCitizen 
// false || false = false 

// THE FINAL RESULT IS FALSE (A student is not fully verified for all school processes)