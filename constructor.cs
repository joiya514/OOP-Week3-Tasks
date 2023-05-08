using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Tasks.BL
{
    class constructor
    {
        public constructor()
        {
            name = "me";
            mathMarks = 100f;
            urduMarks = 90f;
            engMarks = 95.23f;
        }
        public constructor(string n)
        {
            name = n;
            mathMarks = 100f;
            urduMarks = 90f;
            engMarks = 95.23f;
        }
        public constructor(float n)
        {
            name = "jsj";
            mathMarks = n;
            urduMarks = 90f;
            engMarks = 95.23f;
        }
        public string name;
        public float mathMarks;
        public float urduMarks;
        public float engMarks;
    }
}
