using System;
using System.Collections.Generic;
using System.Text;

namespace Study_program
{
    class Course
    {
        int code;
        string title;
        bool isSpecial;
        int lectureHours;
        int practiceHours;
        bool hasExam;
        bool hasCoursePaper;
        List<int> prerequisities;
        Course(int code, string title, bool isSpecial, int lectureHours, int practiceHours, bool hasExam, bool hasCoursePaper)
        {
            this.code = code;
            this.title = title;
            this.isSpecial = isSpecial;
            this.practiceHours = practiceHours;
            this.hasExam = hasExam;
            this.hasCoursePaper = hasCoursePaper;
        }
    }
}
