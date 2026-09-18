using System;

public class Student
{
    private string name;
    private double score;
    private static int totalStudents = 0;

    // Constructor
    public Student(string name, double score)
    {
        this.name = name;
        this.score = score;
        totalStudents++;
    }

    // Instance Method
    public string GetName()
    {
        return this.name;
    }

    // Instance Method
    public double GetScore()
    {
        return this.score;
    }

    // Instance Method
    public bool IsPassed()
    {
        return this.score >= 5.0;
    }

    // Instance Method
    public string GetClassification()
    {
        if (this.score >= 8.0) return "Excellent";
        else if (this.score >= 6.5) return "Good";
        else if (this.score >= 5.0) return "Average";
        else return "Weak";
    }

    // Static Method
    public static int GetTotalStudents()
    {
        return totalStudents;
    }

    // Static Method
    public static Student FindTopStudent(Student[] students)
    {
        Student topStudent = students[0];
        for (int i = 1; i < students.Length; i++)
        {
            if (students[i].score > topStudent.score)
            {
                topStudent = students[i];
            }
        }

        return topStudent;
    }

    // Static Method
    public static double CalculateAverageScore(Student[] students)
    {
        double totalScore = 0;

        foreach (Student student in students)
        {
            totalScore += student.score;
        }

        return totalScore / students.Length;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student[] students =
        {
            new Student("Ton That Loc", 8.5),
            new Student("Anh Tuan", 7.0),
            new Student("Hoang Long", 9.0),
            new Student("Le The Khai", 5.5),
            new Student("Tan Tai", 4.0)
        };

        // Print total number of students
        Console.WriteLine("Total students: " + Student.GetTotalStudents());
        Console.WriteLine();

        // Print student information
        Console.WriteLine("Student List:");

        foreach (Student student in students)
        {
            Console.WriteLine(
                "Name: " + student.GetName() +
                ", Score: " + student.GetScore() +
                ", Classification: " + student.GetClassification() +
                ", Status: " + (student.IsPassed() ? "Pass" : "Fail")
            );
        }
        Console.WriteLine();

        //Find top student
        Student topStudent = Student.FindTopStudent(students);

        Console.Write("Top Student: ");
        Console.WriteLine(
            "Name: " + topStudent.GetName() +
            ", Score: " + topStudent.GetScore()
        );
        Console.WriteLine();

        //Calculate average score
        double average = Student.CalculateAverageScore(students);
        Console.WriteLine("Class Average Score: " + average.ToString("F2"));
    }
}
