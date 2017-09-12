using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public Position Pos { get; set; }
        public double Salary { get; set; }
        public DateTime HiringDate { get; set; }
    }
}
