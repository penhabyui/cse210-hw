using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        Assignment assignment = new Assignment("Samuel Bennett","Multiplication");
        //string summary = assignment.GetSummary();
        //Console.WriteLine(summary);

        MathAssignment mathAssignment = new MathAssignment("Samuel Bennett","Multiplication","Section 7.3","Problems 8-19");
        //string summary1 = mathAssignment.GetSummary();
        //string homework = mathAssignment.GetHomeworkList();
        //Console.WriteLine(summary1);
        //Console.WriteLine(homework);

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters","European History","The Causes of World War II by Mary Waters");
        string name = writingAssignment.GetStudentName();
        string sum = writingAssignment.GetSummary();
        string info = writingAssignment.GetWritingInformation();
        Console.WriteLine(sum);
        Console.WriteLine(info);
    }
}