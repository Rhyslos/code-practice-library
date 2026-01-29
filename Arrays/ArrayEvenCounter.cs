using static Functions.Shortcuts;

namespace IsArrayEven;

public static class isArrayEven{
    
    public static void Main()
    {
        int[] array = [1, 2, 3, 4, 5, 6, 7, 8, 9];
        int evenAmount = 0;
        int oddAmount  = 0;

        for(int i = 0; i < array.Length; i++){
            if (array[i] % 2 == 0)
            {
                evenAmount++;
            }
            else
            {
                oddAmount++;
            }
        }

        write("The amount of even numbers is: " + evenAmount);
    }
}

// This task i managed to do with no ai, and only one mistake. I had forgotten to put [i] 
// in the if statement in the for loop first time i tried to run it.
// Although a simple assignment, it felt good to nail it first try