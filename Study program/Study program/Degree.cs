using System;
using System.Collections.Generic;
using System.Text;

namespace Study_program
{
    class Degree
    {
        int code;
        string title;
        int creditsRequired;
        int specialCoursesRequired;
        Degree(int code, string title, int creditsRequired, int specialCoursesRequired)
        {
            this.code = code;
            this.title = title;
            this.creditsRequired = creditsRequired;
            this.specialCoursesRequired = specialCoursesRequired;
        }
    }
}
