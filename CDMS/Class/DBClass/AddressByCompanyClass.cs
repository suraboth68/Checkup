using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDMS.Class.DBClass
{
    class AddressByCompanyClass
    {
        public int _AddrCom_Key { get; set; }
        public string _AddrCom_Address_NO { get; set; }
        public string _AddrCom_Address_Moo { get; set; }
        public string _AddrCom_Address_Soi { get; set; }
        public string _AddrCom_Address_Street { get; set; }
        public int _AddrCom_Address_District { get; set; }
        public int _AddrCom_Address_Amphur { get; set; }
        public int _AddrCom_Address_Province { get; set; }
        public int _AddrCom_Address_ZipCode { get; set; }
        public string _AddrCom_Telelphone { get; set; }
        public DateTime _AddrCom_CreateDateTime { get; set; }
        public string _AddrCom_CreateBy { get; set; }
        public DateTime _AddrCom_ModifyDateTime { get; set; }
        public string _AddrCom_ModifyBy { get; set; }
        public string _AddrCom_Status { get; set; }
        public string _AddrCom_Del { get; set; }
        public int _Emp_Key { get; set; }
        public string _AddrCom_Name { get; set; }
    }
}
