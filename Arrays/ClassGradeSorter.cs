using static Functions.Shortcuts;

namespace gradeSorter;

public class GradeSorter
{
    public static void Main()
    {

        Random gradeScore = new Random();
        List<string> grade = new List<string>();
        List<string> gradedList = new List<string>();

        
        string[] students = [
            "James Smith ", "Maria Garcia ", "Robert Johnson ", 
            "Lisa Miller ", "Michael Davis ", "Sarah Wilson ", 
            "David Moore ", "Jennifer Taylor ", "William Anderson ", 
            "Ellie Thomas ", "Sullivan Myers ", "Jack Callahan ",
        ];

        for(int i = 0; i < students.Length; i++)
        {

            int score = gradeScore.Next(101);

            switch (score){
                case >= 92:
                grade.Add("A");
                break;

                case >= 84 and < 92:
                grade.Add("B");
                break;

                case >= 76 and < 84:
                grade.Add("C");
                break;

                case >= 68 and < 76:
                grade.Add("D");
                break;

                case >= 60 and < 68:
                grade.Add("E");
                break;

                case >= 0 and < 60:
                grade.Add("F");
                break;
            }
            
        }

        for(int i = 0; i < students.Length; i++)
        {
            string result = students[i] + " - " + grade[i];
            gradedList.Add(result);
            write(result);
        }
    }
}


// This task could have been solved many ways. In essence i only need to print out a name with a grade. 
// This was the first idea of how to solve it. Using the index as the identifier to connect the name with the grade.
// because the score is randomized and the point of the task was not to re-order the arrays or have persistent storage for the grades, it works just fine.
// It was nice getting an introduction to Switch/Case syntax.