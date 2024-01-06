using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System
{
    internal class Payment
    {
        public int PaymentID { get; set; }
        public DateTime PayDate { get; set; }
        public string PaymentMethod { get; set; }
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string Grade { get; set; }
        public string ClassName { get; set; }
        public string FeeType { get; set; }
        public int Amount { get; set; }
        public string Paid { get; set; }
        public DateTime DueDate { get; set; }

    }
}
