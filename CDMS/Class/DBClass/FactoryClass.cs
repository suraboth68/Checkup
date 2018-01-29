using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDMS.Class.DBClass
{
    public class FactoryClass
    {
        public int _Fact_Key { get; set; }
        public int _Fact_Code { get; set; }
        public string _Fact_Name { get; set; }
        public string _Fact_REM { get; set; }
        public DateTime _Fact_CreateDateTime { get; set; }
        public string _Fact_CreateBy { get; set; }
        public DateTime _Fact_ModifyDateTime { get; set; }
        public string _Fact_ModifyBy { get; set; }
        public string _Fact_Status { get; set; }
        public string _Fact_Del { get; set; }
    }
}
