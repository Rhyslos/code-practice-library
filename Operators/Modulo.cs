
namespace PracticeModulo;

public class OddOrEvenCheck
{

    public static void Main()
    {

        Console.WriteLine("Enter a number");

        string textInput = Console.ReadLine();

        double inputNumber = double.Parse(textInput);

        int parsedNumber = (int)ConvertedNumber(inputNumber);

        bool isEven = CheckForNumber(parsedNumber);

        System.Console.WriteLine(isEven);
    }
}


// first modulo attempt, keeping because it's fun to see where i started from to what end result became

/*
public class OddOrEvenCheck
{
    static void Main(int[] args)
    {
        int myNumber = 4;

        if (myNumber % 2 == 0)
        {
            Console.WriteLine("Number is even");
        } else
        {
            Console.WriteLine("Number is Odd");
        }
    }
}
*/