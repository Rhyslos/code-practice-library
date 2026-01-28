using static Functions.Shortcuts;

namespace ArrayAdder;

// My solution based on AI, but actually working
public class ArrayAdder
{
    public static void Main()
    {
        int[] array = [5, 4, 1, 3, 2];
        int firstValue = 0;
        int lastValue = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (i == 0)
            {
                firstValue = array[i];
            }

            if (i == 4)
            {
                lastValue = array[i];
            }
        }

        write(firstValue + lastValue);
    }
}

// My first and failed attempt
/* public class ArrayAdder
{
    public static void Main()
    {
        Array array = [5, 4, 1, 3, 2];

        for (int i = 0; i > array.Length; i++)
        {

            if(i == [0])
            {
                int firstIndex = array[0];
                return firstIndex;
            }
            if(i == [4])
            {
                int secondIndex = array[4];
                return secondIndex;
            }
        }

        write();

    }
}*/