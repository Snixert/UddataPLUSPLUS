using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace UddataPLUSPLUS
{
    enum Subjects
    {
        [Description("English")]
        ENG,
        [Description("Programming")]
        PROG,
        [Description("Geography")]
        GEO
    }
    class Subject : Person
    {
        public int Grade { get; set; }
        public Subjects Subjects {  get; set; }

    }
}
