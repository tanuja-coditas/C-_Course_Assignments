
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

        int MarksSecured { get;  }
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

        public int MarksSecured {
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

    public class Option:IOption
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
