using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System
{
    internal class Exam
    {
        public int ExamId { get; set; }
        public string ExamName { get; set; }
        public string Grade { get; set; }
        public DateTime ExamDate { get; set; }
        public DateTime ExamTime { get; set; }
        public DateTime SearchExamDate { get; set; }
        public string NameInvigilator { get; set; }
    }
}
