using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Student
    {
        private static int studentid;
        public Student()
        {
            studentid++;
            studentID = studentid;
        }
        public int studentID;
        public Student(string name, DateTime dob, string gen, int cls, string sec, string staffname)
        {
            Name = name;
            DOB = dob;
            Gender = gen;
            clss = cls;
            Section = sec;
            StaffName = staffname;
        }
        public string Name { get; set; }
        public DateTime DOB;
        public string Gender;
        public int clss;
        public string Section;
        public string StaffName;
        public void Display()
        {
            Console.WriteLine(this.studentID+"\t"+this.Name+"\t"+this.DOB+"\t"+this.Gender+"\t"+this.clss+"\t"+"\t"+this.Section+"\t"+this.StaffName);
            
        }

    }
}
