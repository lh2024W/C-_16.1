using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__16._1
{
    internal class Group
    {
        List<Student> students = new List<Student>();
        public string? GroupName { get; set; }
        public string? Specialization { get; set; }
        public int StudentCount { get; set; }

    }
}
