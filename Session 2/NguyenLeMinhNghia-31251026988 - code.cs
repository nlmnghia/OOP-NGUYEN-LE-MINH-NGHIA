using System;

public class Student
{
    private string name;
    private double score;
    private static int totalStudents = 0;

    public Student(string name, double score)
    {
        this.name = name;
        this.score = score;
        totalStudents++;
    }

    // TODO: write instance methods here
    public string getname()
    {
        return this.name;
    }

    public double getscore() 
    {
        return this.score;
    }

    public bool IsPassed()
    {
        return this.score >= 5;
    }

    public string GetClassification()
    {
        if (this.score >= 8)
            return "excellent";
        if (this.score >= 6.5)
            return "Good";
        if (this.score >= 5.0)
            return "Average";
        return "weak";
    }
    // TODO: write static methods here

    public static int GetTotalStudents()
    {
        return totalStudents;
    }

    public static Student FindTopStudent(Student[] students)
    {
       
        Student maxstudent = students[0];

       
        for (int i = 1; i < students.Length; i++)
        {
            if (students[i].getscore() > maxstudent.getscore())
            {
                maxstudent = students[i];
            }
        }
        return maxstudent;
    }
}

public static double CalculateAverageScore(Student[] students)
{
    double sum = 0;

    for (int i = 0; i < students.Length; i++)
    {
        sum = sum + students[i].getscore();
    }

    return sum / students.Length;
}

}

class Program
{
    static void Main(string[] args)
    {
        // TODO: create array of Student objects

        Student[] students = new Student[]
        {
            new student ("trong", 8.5)
            new student ("son", 9.4)
            new student ("nghia", 10)
            new student ("anh", 7.8)
            new student ("kiet", 5.5)
        }

        Console.WriteLine($"Total of student create: " + Student.GetTotalStudents());

        Console.WriteLine("Student list:");
        for (int i = 0; i < students.Length; i++)
        {
            
            string status = "";
            if (students[i].IsPassed() == true)
            {
                status = "Pass";
            }
            else
            {
                status = "Fail";
            }


            Console.WriteLine($"- {students[i].GetName()}: Score = {students[i].GetScore()} | Class = {students[i].GetClassification()} | Status = {status}");
        }
        

        
        Student topStudent = Student.FindTopStudent(students);
        if (topStudent != null)
        {
            Console.WriteLine("Top Student: " + topStudent.GetName() + " (Score: " + topStudent.GetScore() + ")");
        }

        
        double averageScore = Student.CalculateAverageScore(students);
        Console.WriteLine("Class Average: " + averageScore);

    }
}}
