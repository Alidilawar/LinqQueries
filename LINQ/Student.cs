using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Student
    {
        public int StuId { get; set; }
        public string StuName { get; set; }
        public string StuEmail { get; set; }
        public int StuMarks { get; set; }
        public List<Subject> Subject { get; set; }
    }
    class Subject
    {
        public string subName { get; set; }
        public int subMarks { get; set; }
    }
}
