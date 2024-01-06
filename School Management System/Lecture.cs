using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System
{
    internal class Lecture
    {
        public int LectureId { get; set; }
        public string LectureName { get; set; }
        public string Grade { get; set; }
        public DateTime LectureDate { get; set; }
        public DateTime LectureTime { get; set; }
        public DateTime SearchLectureDate { get; set; }
        public string LecturerName { get; set; }
    }
}
