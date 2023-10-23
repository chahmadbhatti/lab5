//213047

using System;

class Program
{
    static void Main()
    {
        int[,] testMarks = new int[5, 10];
        InitializeTestMarks(testMarks);
        DisplayTestMarks(testMarks);

        int course = 2;
        int student = 4;
        int mark = testMarks[course, student];
        Console.WriteLine($"Test mark for course {course + 1}, student {student + 1}: {mark}");
    }

    static void InitializeTestMarks(int[,] marks)
    {
        for (int course = 0; course < 5; course++)
        {
            for (int student = 0; student < 10; student++)
            {
                marks[course, student] = 80 + course * 5 + student;
            }
        }
    }

    static void DisplayTestMarks(int[,] marks)
    {
        Console.WriteLine("Test Marks:");

        for (int course = 0; course < 5; course++)
        {
            for (int student = 0; student < 10; student++)
            {
                Console.WriteLine($"Course {course + 1}, Student {student + 1}: {marks[course, student]}");
            }
        }
    }
}
