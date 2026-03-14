/*int[] scores = { 45, 70, 55, 30, 90, 60}; // int Array of scores

// Variable to store calculation

int highest = scores[0];
int lowest = scores[0];
int sum = 0;
int aboveAverageCount = 0;

//print all scores on the same line
Console.Write("Scores:");
for (int i = 0; i < scores.Length; i++)

  
{
    Console.Write(scores[i]);
    if (i < scores.Length - 1)  // print comma except the last score
    {
        Console.Write(", ");
    }

    if (scores[i] > highest) // loop through and check the current score is the highest
    {
        highest = scores[i];
    }

    if (scores[i] < lowest)// loop through and check if the score is lower than lowest
    {
        lowest = scores[i];
    }
    sum += scores[i];

}
double average = (double)sum / scores.Length;  // calculating the average

//count students above average
for (int i = 0; i < scores.Length; i++)
if (scores[i] > average)
{
    aboveAverageCount++;
}
// printing out results
Console.WriteLine();
Console.WriteLine($"Highest Score: {highest}");
Console.WriteLine($"Lowest Score: {lowest}");
Console.WriteLine($"Average Score: {average}");
Console.WriteLine($"Above Average Score: {aboveAverageCount}");

//check pass or fail for each student
for (int i = 0; i < scores.Length; i++)
    if(scores[i] >= 50)
{
  Console.WriteLine($"Student {i + 1} Passed");  
}
    else
    {
        Console.WriteLine($"Student {i + 1} Failed"); 
    }*/
////////////////////////////////////////////////////////
//TASK 2 - ARRAY FILTER AND REVERSE

int[] temperatures = { 25, 32, 28, 35, 30, 29, 40 };
int threshold = 30;
int sum = 0;
double average;

// 1. Print all temperatures
Console.Write("All temperatures: ");
for (int i = 0; i < temperatures.Length; i++)
{
    Console.Write(temperatures[i]);

    // Print comma except after the last value
    if (i < temperatures.Length - 1)
    {
        Console.Write(", ");
    }
}
Console.WriteLine();


// 2. Print temperatures above the threshold
Console.Write("Temperatures above 30: ");
for (int i = 0; i < temperatures.Length; i++)
{
    // Check if temperature is greater than the threshold
    if (temperatures[i] > threshold)
    {
        Console.Write(temperatures[i] + ", ");
    }
}
Console.WriteLine();


// 3. Reverse the array and print it
Console.Write("Reversed temperatures: ");

// We start from the last index (Length - 1) and move backwards
for (int i = temperatures.Length - 1; i >= 0; i--)
{
    Console.Write(temperatures[i]);
    
    if (i > 0)
    {
        Console.Write(", ");
    }
}
Console.WriteLine();


// 4. Calculate average temperature
for (int i = 0; i < temperatures.Length; i++)
{
    // Add each temperature to sum
    sum += temperatures[i];
}

// Average = total sum divided by number of elements
average = (double)sum / temperatures.Length;

Console.WriteLine($"Average temperatures: {average}");
   