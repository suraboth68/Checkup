using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDMS.Class.DBClass
{
    public class SectionClass
    {
        public int _Sec_Key { get; set; }
        public int _Sec_Code { get; set; }
        public string _Sec_Name { get; set; }
        public string _Sec_REM { get; set; }
        public int _Fact_Key { get; set; }
        public int _Brn_Key { get; set; }
        public DateTime _Sec_CreateDateTime { get; set; }
        public string _Sec_CreateBy { get; set; }
        public DateTime _Sec_ModifyDateTime { get; set; }
        public string _Sec_ModifyBy { get; set; }
        public string _Sec_Status { get; set; }
        public string _Sec_Del { get; set; }
    }
}
