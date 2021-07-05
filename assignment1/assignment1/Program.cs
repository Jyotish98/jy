using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                GetInfo();
            }
             void GetInfo()
            {

                StaffRepository staffrepository = new StaffRepository();
                StudentRepository studentrepository = new StudentRepository();
                List<string> Students = new List<string>();
                List<string> Studentstf = new List<string>();

                string ans = "y";
                do
                {

                    Console.WriteLine("1.Add staff to the systyem");
                    Console.WriteLine("2.Add student to the systyem");
                    Console.WriteLine("3.Show students according to their class");
                    Console.WriteLine("4.Add student to the systyem");
                    Console.WriteLine("5.show students");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter staff name");
                            String Stname = Console.ReadLine();
                            Console.WriteLine("Enter staff ID");
                            int StID = int.Parse(Console.ReadLine());
                            staff Staff = new staff() { StaffName = Stname, StaffID = StID };
                            if(staffrepository.SearchStaffID(StID) == false)
                            {
                                staffrepository.Addstaff(Staff);
                                Console.WriteLine("Successfuly added");
                            }
                            else
                            {
                                Console.WriteLine("invalide ID");
                            }



                            break;
                        case 2:
                            Console.WriteLine("Enter student name");
                            string nm = Console.ReadLine();
                            Console.WriteLine("Enter Date of birth");
                            DateTime db = DateTime.Parse(Console.ReadLine());
                            Console.WriteLine("Enter gender");
                            string gn = Console.ReadLine();
                            Console.WriteLine("Enter class");
                            int cl = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the section");
                            string sc = Console.ReadLine();
                            Console.WriteLine("Enter StaffName");
                            //try
                            //{
                                string sn = Console.ReadLine();
                                Student student = new Student() { Name = nm, DOB = db, Gender = gn, clss = cl, Section = sc, StaffName = sn };
                                if (staffrepository.SearchStaffName(sn) == true )
                                {
                                    studentrepository.AddStudent(student);
                                Console.WriteLine("Successfuly added");
                                }
                                else
                                {
                                    Console.WriteLine("staff name is invalide");
                                }
                                
                            //}
                            
                            break;
                        case 3:
                            Console.WriteLine("Enter Class");
                            int cls = int.Parse(Console.ReadLine());
                            Students = studentrepository.DisplayStudentsasperclass(cls);
                            Console.WriteLine("these students are in class {0}", cls);
                            for (int i = 0; i<Students.Count; i++)
                            {
                                Console.WriteLine(Students[i]);
                                
                            }

                            break;
                        case 4:
                            Console.WriteLine("Enter staff name");
                            string stnm = (Console.ReadLine());
                            Studentstf = studentrepository.DisplayStudentsasperstaff(stnm);
                            Console.WriteLine("these students are {0}", stnm);
                            for (int i = 0; i < Studentstf.Count; i++)
                            {
                                Console.WriteLine(Studentstf[i]);

                            }

                            break;

                            //    case 5:
                            //        Console.WriteLine("StudentID\tName\tDOB\t\t\tGender\t clss\tstction\tStaffName");
                            //        foreach (var c in studentlist)
                            //        {
                            //            c.Display();
                            //        }

                            //        break;
                    }

                }
                    while (ans == "y");

            }
        }
    }
}
