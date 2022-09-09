using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal interface ICompany
    {
        public string CompanyName { get; set; }
        public bool OpenWeekends { get; set; }
    }
}
