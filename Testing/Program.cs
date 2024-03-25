//// See https://aka.ms/new-console-template for more information
//Console.WriteLine(" ");
//Console.WriteLine("Please input your username");

//string UserName = Console.ReadLine();

//Console.WriteLine("Hello "  + UserName);

using System;
using Testing;
class Shape
{
    static void Main()
    {
        List<GPA> gpaList = new List<GPA>();
        List <int> selectedCourses = new List<int>();
        int userInputCount = 0;
    Start:
        Console.WriteLine("Please select your course code: 1 - MTH101, 2 - GS101, 3 - NET101, 4 - C#101, 5 - HCI101");
        int courseCode = int.Parse(Console.ReadLine());
        string courseDes = string.Empty;
        int courseUnit;
        if (selectedCourses.Contains(courseCode))
        {
            Console.WriteLine("Number have been used, please input another coursecode");
            goto Start;
        }
        switch (courseCode)
        {
            case 1:
                courseUnit = 5;
                courseDes = "MTH101";
                // Course unit for MTH101
                break;
            case 2:
                courseUnit = 3; // Course unit for GS101
                courseDes = "GS101";
                break;
            case 3:
                courseUnit = 5; // Course unit for NET101
                courseDes = "NET101";
                break;
            case 4:
                courseUnit = 5; // Course unit for C#101
                courseDes = "C#101";
                break;
            case 5:
                courseUnit = 3; // Course unit for HCI101
                courseDes = "HCI101";
                break;
            default:
                Console.WriteLine("Invalid course code");
                goto Start;
        }
        selectedCourses.Add(courseCode);
        Console.WriteLine("Please enter your grade: ");
        // Determine the letter grade based on the input grade
        int grade = int.Parse(Console.ReadLine());
        string letterGrade;
        int gradeUnit = 0;
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

        
        // calculate the weight point
        weightPoint = gradeUnit * courseUnit;
        // calculate the GPA
        float totalWeightPoint;
        totalWeightPoint = weightPoint * 5;
        float totalCourseUnit;
        totalCourseUnit = 21;
        float gpa = totalWeightPoint / totalCourseUnit;
        string formattedValue = gpa.ToString("F2");

        var gpaIndividual = new GPA()
        {
            CourseDes = courseDes,
            CourseUnit = courseUnit,
            Grade = grade,
            GradeUnit = gradeUnit,
            WeightPoint = weightPoint,
            Gpa = gpa,
            LetterGrade = letterGrade
        };
        gpaList.Add(gpaIndividual);
        // Output the letter grade and weight point 
        Console.WriteLine("selection count: {0}", userInputCount);
        userInputCount++;
        if (userInputCount <= 4)
        {
            goto Start;
        }

        for (int i = 0; i < gpaList.Count; i++)
        {
            Console.WriteLine("Course Code: " + gpaList[i].CourseDes);
            Console.WriteLine("Course Unit: " + gpaList[i].CourseUnit);
            Console.WriteLine("Grade: " + gpaList[i].Grade);
            Console.WriteLine("Grade Unit: " + gpaList[i].GradeUnit);
            Console.WriteLine("Weight Point: " + gpaList[i].WeightPoint);
            Console.WriteLine("Letter Grade: " + gpaList[i].LetterGrade);
            //Console.WriteLine("GPA: " + gpa);
            Console.WriteLine("--------------------------------------------------------------------");
        }

        gpa = gpaList.Sum(wp=>wp.WeightPoint)/totalCourseUnit;

        Console.WriteLine("GPA: " + formattedValue);

        
        //Console.WriteLine("Please select target");
        //int UserTarget = int.Parse(Console.ReadLine());

        //int Start = 0;

        //while (Start <= UserTarget) 
        //{
        //    Console.WriteLine(Start);
        //    Start = Start + 2;
        //}
        //    int Totalcoffeecost = 0; //coffeeshop application

        //    Start:
        //    Console.WriteLine("Please select your coffee size: 1 - small, 2 - medium, 3 - large");
        //    int UserChoice = int.Parse(Console.ReadLine());

        //    switch (UserChoice) 
        //    {
        //        case 1:
        //            Totalcoffeecost += 1;
        //            break;
        //        case 2:
        //            Totalcoffeecost += 2;
        //            break;
        //        case 3:
        //            Totalcoffeecost += 3;
        //            break;
        //            Console.WriteLine("Your choice (0) is invalid", UserChoice);
        //            goto Start;
        //    }
        //Decide:
        //    Console.WriteLine("Do you want to buy another coffee - Yes or No?");
        //    string UserDecision = Console.ReadLine();

        //    switch (UserDecision.ToUpper()) 
        //    {
        //        case "YES":
        //            goto Start;
        //        case "NO":
        //            break;
        //        default:
        //            Console.WriteLine("Your choice (0) is invalid. Please try again...", UserDecision);
        //            goto Decide;
        //    }
        //    Console.WriteLine("Thank you for shopping with us");
        //    Console.WriteLine("Bill amount = $(0)", Totalcoffeecost);

        //Console.WriteLine("Please enter a number");

        //int UserNumber = int.Parse(Console.ReadLine());

        //if (UserNumber == 1) 
        //{
        //    Console.WriteLine("Your number is one");
        //}
        //if (UserNumber == 2)
        //{
        //    Console.WriteLine("Your number is Two");
        //}
        //if (UserNumber == 3)
        //{
        //    Console.WriteLine("Your number is Three");
        //}
        //if (UserNumber == 4)
        //{
        //    Console.WriteLine("Your number is Four");
        //}


        //bool? AreyouMajor = true;

        //if (AreyouMajor == true) 
        //{
        //    Console.WriteLine("User is Major");
        //}
        //else if (AreyouMajor == false) 
        //{
        //    Console.WriteLine("User is Major");
        //}
        //else 
        //{
        //    Console.WriteLine("User did not answer the question");

        //string Name = "One\nTwo\nThree"; //n stands for new paragraph
        //Console.WriteLine(Name);

        //Console.WriteLine("Please input your firstname");
        //string FirstName = Console.ReadLine();

        //Console.WriteLine("Please input your lastname");
        //string LastName = Console.ReadLine();

        //Console.WriteLine("Hello " + FirstName + " " + LastName);
    }
}



