using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class StaffRepository
    {
        List<staff> stafflist = new List<staff>();
        public void Addstaff (staff Staff)
        {
            stafflist.Add(Staff);
        }
        public bool SearchStaffID(int id)
        {
            foreach (var c in stafflist)
            {
                if (c.StaffID == id)
                    return true;
            }
            return false;
        }
        public bool SearchStaffName(string name)
        {
            foreach (var c in stafflist)
            {
                if (c.StaffName == name)
                    return true;
            }
            return false;
        }

    }
}
