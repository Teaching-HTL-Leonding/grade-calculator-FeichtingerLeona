Console.Clear();
Console.WriteLine("Have you participated in the first exam?");
string TEST1 = Console.ReadLine()!;

int testpoints = 0;
int maxTestPoints = 0;

if (TEST1 == "yes")
{
    Console.WriteLine("please enter your points (0-20)");
    testpoints += int.Parse(Console.ReadLine()!);
    maxTestPoints += 20;
}
else if (TEST1 == "no")
{
    maxTestPoints += 0;
}

Console.WriteLine("Have you participated in the second exam?");
string TEST2 = Console.ReadLine()!;
if (TEST2 == "yes")
{
    Console.WriteLine("please enter your points (0-20)");
    testpoints += int.Parse(Console.ReadLine()!);
    maxTestPoints += 20;
}
else if (TEST2 == "no")
{
    maxTestPoints += 0;
}

Console.WriteLine("Have you participated in an oral exam exam?");
string TEST3 = Console.ReadLine()!;
if (TEST3 == "yes")
{
    Console.WriteLine("please enter your points (0-20)");
    testpoints += int.Parse(Console.ReadLine()!);
    maxTestPoints += 20;
}
else if (TEST3 == "no")
{
    maxTestPoints += 0;
}



Console.WriteLine("Enter the points you got for your homework(0-20) ");
testpoints += int.Parse(Console.ReadLine()!);
maxTestPoints += 20;

int percentage = (testpoints / maxTestPoints) * 100;
if (percentage >= 89)
{
    Console.WriteLine("Congratulation, you have a 1 !! ");
}
else if (percentage >= 76)
{
    Console.WriteLine("Congratulation, you have a 2 !! ");
}
else if (percentage >= 63)
{
    Console.WriteLine("Congratulation, you have a 3 !! ");
}
else if (percentage >= 50)
{
    Console.WriteLine("You have a 4 !! ");
}
else if (percentage <= 50)
{
    Console.WriteLine("You have a 5 !! ");
}