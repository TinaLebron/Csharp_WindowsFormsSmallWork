using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray.src.model
{
    public class Course
    {
        string subject;

        public Course()
        {
            
        }

        public Course(string subject)
        {
            this.subject = subject;
        }

        public string Subject
        {
            get
            {
                return subject;
            }
            set
            {
                subject = value;
            }
        }
    }
}
