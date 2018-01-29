using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDMS.Class.DBClass
{
    public class BranchClass
    {
        public int _Brn_Key { get; set; }
        public int _Brn_Code { get; set; }
        public string _Brn_Name { get; set; }
        public string _Brn_REM { get; set; }
        public int _Fact_Key { get; set; }
        public DateTime _Brn_CreateDateTime { get; set; }
        public string _Brn_CreateBy { get; set; }
        public DateTime _Brn_ModifyDateTime { get; set; }
        public string _Brn_ModifyBy { get; set; }
        public string _Brn_Status { get; set; }
        public string _Brn_Del { get; set; }
    }
}
