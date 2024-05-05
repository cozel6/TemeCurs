using System;

namespace ClassStudentAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[0];
            int studentCount = 0;
            while (true)
            {
                Console.WriteLine("Enter a student name (or 'finish' to finish)");
                string name = Console.ReadLine();
                if (name.ToLower() == "finish")
                {
                    break;
                }
                Console.WriteLine("Please enter the student's age: ");
                int age = int.Parse(Console.ReadLine());
                students = AddStudent(students, new Student(age, name));
            }

            // Read marks for each student
            foreach (var student in students)
            {
                Console.Write($"Enter mark for {student.Info}: ");
                string markInput = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(markInput))
                {
                    student.Mark = int.Parse(markInput);
                }
            }

            // Calculate total marks and count students with marks
            int totalMarks = 0;
            int studentCountWithMark = 0;
            foreach (var student in students)
            {
                if (student.Mark.HasValue)
                {
                    totalMarks += student.Mark.Value;
                    studentCountWithMark++;
                }
            }

            // Calculate average mark (after all marks have been input)
            double averageMark = studentCountWithMark > 0 ? (double)totalMarks / studentCountWithMark : 0;

            // Output student info and average mark
            Console.WriteLine("\nStudent Info: ");
            foreach (Student student in students)
            {
                Console.WriteLine(student.Info);
            }
            Console.WriteLine($"\nAverage Mark: {averageMark}");
        }

        static Student[] AddStudent(Student[] array, Student student)
        {
            Student[] newArray = new Student[array.Length + 1];
            Array.Copy(array, newArray, array.Length);
            newArray[array.Length] = student;
            return newArray;
        }
    }
}
