/*
Processing array data in C# using foreach, if-else if-else structures

4 students are assigned random scores and their individual average scores 
graded based on a predetermined grading system. These grades are displayed to the user
*/

Random score = new Random();

int currentAssignments = 5;
string[] studentNames = ["Alice","Brian", "carl", "dave"];
decimal[] allScores;

int[] aliceScores = [score.Next(0,101), score.Next(0,101), score.Next(0,101), score.Next(0,101), score.Next(0,101)];
int[] brianScores = [score.Next(0,101), score.Next(0,101), score.Next(0,101), score.Next(0,101), score.Next(0,101)];
int[] carlScores = [score.Next(0,101), score.Next(0,101), score.Next(0,101), score.Next(0,101), score.Next(0,101)];
int[] daveScores = [score.Next(0,101), score.Next(0,101), score.Next(0,101), score.Next(0,101), score.Next(0,101)];

decimal aliceTotalScore = aliceScores.Sum();
decimal brianTotalScore = brianScores.Sum();
decimal carlTotalScore = carlScores.Sum();
decimal daveTotalScore = daveScores.Sum();

decimal aliceAverageScore = Decimal.Divide(aliceTotalScore, currentAssignments);
decimal brianAverageScore = Decimal.Divide(brianTotalScore, currentAssignments);
decimal carlAverageScore = Decimal.Divide(carlTotalScore, currentAssignments);
decimal daveAverageScore = Decimal.Divide(daveTotalScore, currentAssignments);

allScores = [aliceAverageScore, brianAverageScore, carlAverageScore, daveAverageScore];

string studentGrade = "";

Console.WriteLine($"Student\t\tGrade\n");

foreach (string student in studentNames)
{

}

foreach (string student in studentNames)
{
    foreach (decimal studentScore in allScores)
    {
        if (studentScore >= 97){studentGrade = "A+";}
        else if (studentScore >= 93){studentGrade = "A";}
        else if (studentScore >= 90){studentGrade = "A-";}
        else if (studentScore >= 87){studentGrade = "B+";}
        else if (studentScore >= 83){studentGrade = "B";}
        else if (studentScore >= 80){studentGrade = "B-";}
        else if (studentScore >= 77){studentGrade = "C+";}
        else if (studentScore >= 73){studentGrade = "C";}
        else if (studentScore >= 70){studentGrade = "C-";}
        else if (studentScore >= 67){studentGrade = "D+";}
        else if (studentScore >= 63){studentGrade = "D";}
        else if (studentScore >= 60){studentGrade = "D-";}
        else{studentGrade = "E";}

        Console.WriteLine($"{student}:\t\t{studentScore}\t{studentGrade}");
    }
    break;
}
