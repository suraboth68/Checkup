using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDMS.Class.DBClass
{
    public class AddressByIDCardClass
    {
        public int _AddrIDCard_Key { get; set; }
        public string _AddrIDCard_Address_NO { get; set; }
        public string _AddrIDCard_Address_Moo { get; set; }
        public string _AddrIDCard_Address_Soi { get; set; }
        public string _AddrIDCard_Address_Street { get; set; }
        public int _AddrIDCard_Address_District { get; set; }
        public int _AddrIDCard_Address_Amphur { get; set; }
        public int _AddrIDCard_Address_Province { get; set; }
        public int _AddrIDCard_Address_ZipCode { get; set; }
        public string _AddrIDCard_Telelphone { get; set; }
        public int _Emp_Key { get; set; }
        public DateTime _AddrIDCard_CreateDateTime { get; set; }
        public string _AddrIDCard_CreateBy { get; set; }
        public DateTime _AddrIDCard_ModifyDateTime { get; set; }
        public string _AddrIDCard_ModifyBy { get; set; }
        public string _AddrIDCard_Status { get; set; }
        public string _AddrIDCard_Del { get; set; }        
    }
}
