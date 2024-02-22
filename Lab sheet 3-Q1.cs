using System;

public class Course
{
    // Private fields
    private string courseName;
    private string instructorName;
    private double grade;

    // Public properties
    public string CourseName
    {
        get { return courseName; }
    }

    public double Grade
    {
        get { return grade; }
    }

    // Constructor
    public Course(string courseName, string instructorName, double grade)
    {
        this.courseName = courseName;
        this.instructorName = instructorName;
        SetGrade(grade);
    }

    // Public method to set instructor's name with validation
    public void SetInstructorName(string instructorName)
    {
        if (string.IsNullOrWhiteSpace(instructorName))
        {
            throw new ArgumentException("Instructor name cannot be empty or null.");
        }
        this.instructorName = instructorName;
    }

    // Private method to calculate letter grade based on numeric grade
    private string CalculateLetterGrade()
    {
        if (grade >= 90)
        {
            return "A";
        }
        else if (grade >= 80)
        {
            return "B";
        }
        else if (grade >= 70)
        {
            return "C";
        }
        else if (grade >= 60)
        {
            return "D";
        }
        else
        {
            return "F";
        }
    }

    // Public method to print course information
    public void PrintCourseInfo()
    {
        string letterGrade = CalculateLetterGrade();
        Console.WriteLine($"Course Name: {courseName}");
        Console.WriteLine($"Instructor Name: {instructorName}");
        Console.WriteLine($"Letter Grade: {letterGrade}");
    }

    // Private method to set grade with validation
    private void SetGrade(double grade)
    {
        if (grade < 0 || grade > 100)
        {
            throw new ArgumentException("Grade must be between 0 and 100.");
        }
        this.grade = grade;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Course course = new Course("Computer Science", "Dr. Smith", 85);
        course.SetInstructorName("Prof. Johnson"); // Example of setting instructor's name
        course.PrintCourseInfo(); // Example of printing course information
    }
}








