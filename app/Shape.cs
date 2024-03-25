using System;
class CGPA
{
    static void Main(string[] args)
    {
    Start:
        Console.WriteLine("Please select your course code: 1 - MTH101, 2 - GS101, 3 - NET101, 4 - C#101, 5 - HCI101");
        int courseCode = int.Parse(Console.ReadLine());

        int courseUnit;
        switch (courseCode)
        {
            case 1:
                courseUnit = 5; // Course unit for MTH101
                break;
            case 2:
                courseUnit = 3; // Course unit for GS101
                break;
            case 3:
                courseUnit = 5; // Course unit for NET101
                break;
            case 4:
                courseUnit = 5; // Course unit for C#101
                break;
            case 5:
                courseUnit = 3; // Course unit for HCI101
                break;
            default:
                Console.WriteLine("Invalid course code");
                goto Start;
        }
        Console.WriteLine("Please enter your grade: ");
        // Determine the letter grade based on the input grade
        int grade = int.Parse(Console.ReadLine());
        string letterGrade;
        int gradeUnit;
        int weightPoint = 0;
      
        if (grade >= 70 && grade <= 100)
        {
            letterGrade = "A (Excellent)";
            gradeUnit = 5;
        }
        else if (grade >= 60 && grade <= 69)
        {
            letterGrade = "B (Very Good)";
            gradeUnit = 4;
        }
        else if (grade >= 50 && grade <= 59)
        {
            letterGrade = "C (Good)";
            gradeUnit = 3;
        }
        else if (grade >= 45 && grade <= 49)
        {
            letterGrade = "D (Fair)";
            gradeUnit = 2;
        }
        else if (grade >= 40 && grade <= 44)
        {
            letterGrade = "E (Pass)";
            gradeUnit = 1;
        }
        else if (grade >= 0 && grade <= 39)
        {
            letterGrade = "F (Fail)";
            gradeUnit = 0;
            ;
        }
        else
        {
            letterGrade = "Invalid grade";
        }
        goto Start;
        // calculate the weight point
        weightPoint = gradeUnit * courseUnit;
        // calculate the GPA
        int totalWeightPoint;
        totalWeightPoint = weightPoint * 5;
        int totalCourseUnit;
        totalCourseUnit = 21;
        int gpa = totalWeightPoint / totalCourseUnit;
        // Output the letter grade and weight point
        Console.WriteLine("courseCode" + "courseUnit" + "grade" + "gradeUnit" + "weightPoint");
        Console.WriteLine(courseCode + courseUnit + grade + gradeUnit + weightPoint);

         

    }
}
     

