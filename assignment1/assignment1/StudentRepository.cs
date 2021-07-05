using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class StudentRepository
    {
        List<Student> studentlist = new List<Student>();
        public void AddStudent(Student student)
        {
            studentlist.Add(student);
        }
        public List <string> DisplayStudentsasperclass(int cls)
        {
            List<string> Students = new List<string>();
            foreach(var v in studentlist)
            {
                if (v.clss == cls)
                    Students.Add(v.Name);
            }
            return Students;

        }
        public List<string> DisplayStudentsasperstaff(string stnm)
        {
            List<string> Studentstf = new List<string>();
            foreach(var v in studentlist)
            {
                if (v.StaffName == stnm)
                    Studentstf.Add(v.Name);
            }
            return Studentstf;

        }



    }
}
