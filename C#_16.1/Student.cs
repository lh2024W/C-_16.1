using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__16._1
{
    internal class Student
    {
        public string? FirstName { get; set; }
        public string? Surename { get; set; }
        public string? LastName { get; set; }
        public DateTime BirthdayDate { get; set; }
        Address home;
        Learning learning;
        Group group;
        JournalVisited journalVisited;
    }
}
