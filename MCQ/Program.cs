using System;
using System.Collections.Generic;
using McqClassLibrary;

using System;
using System.Collections.Generic;


namespace McqClassLibrary
{
    public interface ITestPaper
    {

        string SubjectName { get; set; }

        string TestPaperName { get; set; }

        List<IQuestion> Questions { get; set; }

        int Marks { set; get; }
    }

    public interface IQuestion
    {
        string QuestionText { get; set; }

        List<IOption> Options { get; set; }

        char CorrectAnswerLetter { get; set; }

        char OptionSelectedByStudent { get; set; }

        int MarksSecured { get; }
    }

    public interface IOption
    {
        char OptionLetter { get; set; }

        string OptionText { get; set; }
    }

    public interface IStudent
    {
        int RollNo { get; set; }

        string StudentName { get; set; }

        List<ITestPaper> TestPapers { get; set; }
    }


    public class TestPaper : ITestPaper
    {

        private int _marks = 0;
        public string SubjectName { get; set; }

        public string TestPaperName { get; set; }

        public List<IQuestion> Questions { get; set; }

        public int Marks
        {
            set
            {
                _marks = value;
            }
            get
            {
                return _marks;
            }
        }
    }

    public class Question : IQuestion
    {
        int _marksSecured;
        public string QuestionText { get; set; }

        public List<IOption> Options { get; set; }

        public char CorrectAnswerLetter { get; set; }

        public char OptionSelectedByStudent { get; set; }

        public int MarksSecured
        {
            get
            {
                if (this.CorrectAnswerLetter == this.OptionSelectedByStudent)
                {
                    _marksSecured = 1;
                };
                return 0;
            }

        }
    }

    public class Option : IOption
    {
        public char OptionLetter { get; set; }

        public string OptionText { get; set; }
    }

    public class Student : IStudent
    {
        public int RollNo { get; set; }

        public string StudentName { get; set; }

        public List<ITestPaper> TestPapers { get; set; }
    }
}

namespace MCQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int choice = -1;
            List<ITestPaper> testPapers = new List<ITestPaper>();
            do
            {
                Console.WriteLine("Welcome, Are you a..");
                Console.WriteLine("1.Teacher");
                Console.WriteLine("2.Student");
                Console.WriteLine("3.Exit");


                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Lets create a testpaper");

                    for(int k=1;k<=2;k++)
                    {
                        Console.WriteLine($"Test Paper {k}");

                        ITestPaper testpaper = new TestPaper();

                        Console.Write("Subject Name:");
                        testpaper.SubjectName = Console.ReadLine();

                        Console.Write("Test Paper Name: ");
                        testpaper.TestPaperName = Console.ReadLine();

                        List<IQuestion> questions = new List<IQuestion>();
                        Console.WriteLine($"Create 10 Questions for {testpaper.TestPaperName}");
                        for (int i = 10; i <= 10; i++)
                        {
                            Console.WriteLine($"Question {i}");

                            IQuestion question = new Question();

                            Console.Write("Question Text: ");
                            question.QuestionText = Console.ReadLine();

                            Console.WriteLine("Enter the four options");

                            List<IOption> options = new List<IOption>();
                            for (int j = 1; j <= 4; j++)
                            {
                                IOption option = new Option();

                                Console.Write("Option Letter: ");
                                option.OptionLetter = Convert.ToChar(Console.ReadLine());

                                Console.Write("Option Text: ");
                                option.OptionText = Console.ReadLine();

                                options.Add(option);
                            }
                            question.Options = options;

                            Console.Write("Correct Option Letter: ");
                            question.CorrectAnswerLetter = Convert.ToChar(Console.ReadLine());

                            questions.Add(question);

                        }

                        testpaper.Questions = questions;
                        testPapers.Add(testpaper);
                    }

                }
                else if(choice == 2)
                {
                    IStudent student = new Student();

                    Console.Write("Enter Your RollNo: ");
                    student.RollNo = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Your Name: ");
                    student.StudentName = Console.ReadLine();

                    student.TestPapers = testPapers;

                    Console.WriteLine("Test Begins ---");

                    for(int k=0;k<2;k++)
                    {
                        ITestPaper testpaper = student.TestPapers[k];
                        Console.WriteLine($"Test{k + 1}: {testpaper.TestPaperName}");

                        for(int i=0;i<testpaper.Questions.Count;i++)
                        {
                            Console.WriteLine($"{testpaper.Questions[i].QuestionText}");
                            for(int j = 0; j < testpaper.Questions[i].Options.Count;j++)
                            {
                                Console.WriteLine($"{testpaper.Questions[i].Options[j].OptionLetter})  {testpaper.Questions[i].Options[j].OptionText}");
                            }
                            Console.Write("Your Answer: ");
                            testpaper.Questions[i].OptionSelectedByStudent = Convert.ToChar(Console.ReadLine());
                            testpaper.Marks += testpaper.Questions[i].MarksSecured;

                        }
                    }

                    Console.WriteLine("Test Done , Here are your results");
                    for(int k=0;k<2;k++)
                    {
                        ITestPaper testpaper = student.TestPapers[k];
                        Console.WriteLine($"{testpaper.TestPaperName}: {testpaper.Marks}");
                    }
                }
                else
                {
                    Console.WriteLine("Thank you");
                }
            } while (choice != 3);
        }
    }
}
