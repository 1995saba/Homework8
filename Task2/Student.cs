using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    enum Gender
    {
        Male,
        Female
    }

    enum FormOfEducation
    {
        FullTime,
        Extramural
    }

    public class Student
    {
        private string FullName { get; set; }
        public string Group { get; set; }
        public double GPA { get; set; }
        public double InComePerFamilyMember { get; set; }
        private Gender gender;
        private FormOfEducation formOfEducation;

    }
}
