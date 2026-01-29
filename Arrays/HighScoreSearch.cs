using static Functions.Shortcuts;

namespace HighestNumberExtractor;

public static class HighestNumberExtractor
{
    public static void Main()
    {
        List<int> scoreList = new List<int>();
        Random randomGenerator = new Random();

        int highestScore = 0;

        for (int i = 0; i < 50; i++)
        {
            int number = randomGenerator.Next(100);
            scoreList.Add(number);

            if (i == 49)
            {
                for (int l = 0; l < scoreList.Count; l++)
                {
                    if (scoreList[l] > highestScore)
                    {
                        highestScore = scoreList[l];
                    }
                }
            }
        }

        write("The highest number is: " + highestScore);
    }
}

// Here was my attempt to randomly generate numbers and add them to a list, and then find the highest value.
// I had a bit more syntax issues this time around, because both random number generation and lists are a new topic to me.
// Overall my logic was correct, even though it's a less performant solution than if i decided to make the list first, and then loop it afterwards.
// This was my first solution, but i'll attempt a better version later.