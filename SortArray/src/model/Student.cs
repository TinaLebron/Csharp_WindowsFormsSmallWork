using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray.src.model
{
    public class Student
    {
        
        string studentName;
        int studentScore;

        public Student()
        {

        }
        
        public Student(string studentName,int studentScore)
        {
            this.studentName = studentName;
            this.studentScore = studentScore;
        }
        
        public string StudentName
        {
            get
            {
                return studentName;
            }
            set
            {
                studentName = value;
            }
        }

        public int StudentScore
        {
            get
            {
                return studentScore;
            }
            set
            {
                studentScore = value;
            }
        }
    }
}
