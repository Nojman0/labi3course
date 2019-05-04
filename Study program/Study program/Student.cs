using System;
using System.Collections.Generic;
using System.Text;

namespace Study_program
{
    class Student
    {
        public int applicationNumber;
        public string fullName;
        public DateTime birthDate;
        Student(int applicationNumber, string fullName, DateTime birthDate)
        {
            this.applicationNumber = applicationNumber;
            this.fullName = fullName;
            this.birthDate = birthDate;
        }
    }
}
