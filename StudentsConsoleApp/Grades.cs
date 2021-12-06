using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsConsoleApp
{
    internal class Grades
    {
        public string teacherName;
        public string studentName;
        public int idNumber;
        public int[] gradesArray;

        public Grades(string _teacherName, string _studentName, int _idNumber, int[] _gradesArray)
        {
            this.teacherName = _teacherName;
            this.studentName = _studentName;
            this.idNumber = _idNumber;
            this.gradesArray = _gradesArray;
        }

        public string TeacherName { get; set; }
        public string StudentName { get; set; }
        public string IdNumber { get; set; }
        public string GradesArray { get; set; }




    }
}
