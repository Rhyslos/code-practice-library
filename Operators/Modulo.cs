
using Microsoft.VisualBasic;

namespace PracticeModulo;

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