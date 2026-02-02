using static Functions.Shortcuts;


namespace AverageTemperature;

public static class AverageTemperature
{
    public static void Main()
    {
        int[] dailyTemperatures = [15, 14, 12, 18, 19, 16, 25,];

        int average = 0;
        int coldestTemperature = dailyTemperatures[0];

        for(int i = 0; i < dailyTemperatures.Length; i++)
        {
            average = average + dailyTemperatures[i];

            if(dailyTemperatures[i] < coldestTemperature)
            {
                coldestTemperature = dailyTemperatures[i];
            }
        }

        average = average / dailyTemperatures.Length;

        write("The average temperature is " + average);
        write("The coldest temperature is " + coldestTemperature);
    }
}


// Still learning to work more with arrays in C#.