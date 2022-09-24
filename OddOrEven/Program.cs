Console.WriteLine("Enter some random number:");

int UserNum = Convert.ToInt32(Console.ReadLine());

// Is the number that the user entered odd or even?

int Result = UserNum % 2;

// != - Not

if (Result != 0)
{
    Console.WriteLine("The number that you entered is odd.");
}
else
{
    Console.WriteLine("The number that you entered is even.");
}