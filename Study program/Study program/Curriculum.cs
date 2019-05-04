using System;
using System.Collections.Generic;
using System.Text;

namespace Study_program
{
    class Curriculum
    {
        int code;
        DateTime creationDate;
        DateTime confirmationDate;
        Curriculum(int code, DateTime creationDate, DateTime confirmationDate)
        {
            this.code = code;
            this.creationDate = creationDate;
            this.confirmationDate = confirmationDate;
        }
    }
}
