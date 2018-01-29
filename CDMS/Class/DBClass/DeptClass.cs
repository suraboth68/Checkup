using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDMS.Class.DBClass
{
    public class DeptClass
    {
        public int _Dpt_Key { get; set; }
        public int _Dpt_Code { get; set; }
        public string _Dpt_Name { get; set; }
        public string _Dpt_REM { get; set; }
        public int _Fact_Key { get; set; }
        public int _Brn_Key { get; set; }
        public int _Sec_Key { get; set; }
        public DateTime _Dpt_CreateDateTime { get; set; }
        public string _Dpt_CreateBy { get; set; }
        public DateTime _Dpt_ModifyDateTime { get; set; }
        public string _Dpt_ModifyBy { get; set; }
        public string _Dpt_Status { get; set; }
        public string _Dpt_Del { get; set; }
    }
}
