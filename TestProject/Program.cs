using System.Diagnostics;

// No. of Exams
int examAssignments = 5;
// Name of Students
string[] studentName = {"Sophia","Andrew", "Emma", "Logan"};

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

int[] currentScores = new int[10];

// Header
Console.Clear();
Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit");

foreach (string name in studentName)
{
    string currentStudentLetterGrade = "";
    if (name == "Sophia")
    {
        currentScores = sophiaScores;
    }
    else if(name == "Andrew")
    {
        currentScores = andrewScores;
    }
    else if(name == "Emma")
    {
        currentScores = emmaScores;
    }
    else if(name == "Logan")
    {
        currentScores = loganScores;
    }
    
    int scoreCount = 0;
    int creditCount = 0;
    int sumExamScores = 0;
    int sumExtraCredit = 0;

    foreach (int score in currentScores)
    {
        scoreCount++;
        if (scoreCount <= examAssignments)
        {
            sumExamScores += score;
        }
        else
        {
            creditCount++;
            sumExtraCredit += score;
        }
    }

    decimal currentExamScore = (decimal)(sumExamScores)/examAssignments;
    decimal currentCreditScore = (decimal)(sumExtraCredit)/creditCount;
    decimal currentCreditPoints = (decimal)sumExtraCredit/10/examAssignments;
    decimal currentStudentGrade = currentExamScore + currentCreditPoints;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    Console.WriteLine($"{name}\t\t{currentExamScore}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t{currentCreditScore} ({currentCreditPoints}) pts");
}

Console.WriteLine("\n\nPlease enter any key to continue.");
Console.ReadLine();

