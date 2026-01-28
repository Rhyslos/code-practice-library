
namespace PracticeModulo;

public class OddOrEvenCheck
{

    static void Main()
    {
        int num = 4;
        bool isEven = CheckForNumber(num);

        System.Console.WriteLine(isEven);
    }

    public static bool CheckForNumber(int num)
    {
        bool checkedNumber;
    
        if (num % 2 == 0)
        {
            return checkedNumber = true;
        }
        else
        {
            return checkedNumber = false;
        }
        return checkedNumber;
    }           
}


// first modulo attempt

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