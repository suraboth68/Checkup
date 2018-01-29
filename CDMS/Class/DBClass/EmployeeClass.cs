using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDMS.Class.DBClass
{
    public class EmployeeClass
    {
        public int _Emp_Key { get; set; }
        public DateTime _Birthday { get; set; }
        public DateTime _StartDayWork { get; set; }
        public string _IDCard { get; set; }
        public string _EmployeeID { get; set; }
        public string _Emp_Fname { get; set; }
        public string _Emp_Name { get; set; }
        public string _Emp_Surname { get; set; }
        public int _Age { get; set; }
        public string _Title { get; set; }
        public string _Gender { get; set; }
        public int _Dept_Key { get; set; }
        public int _Sec_Key { get; set; }
        public int _Brn_Key { get; set; }
        public int _Fact_Key { get; set; }
        public string _Emp_REM { get; set; }
        public DateTime _Emp_CreateDateTime { get; set; }
        public string _Emp_CreateBy { get; set; }
        public DateTime _Emp_ModifyDateTime { get; set; }
        public string _Emp_ModifyBy { get; set; }
        public string _Emp_Status { get; set; }
        public string _Emp_Del { get; set; }
    }
}
