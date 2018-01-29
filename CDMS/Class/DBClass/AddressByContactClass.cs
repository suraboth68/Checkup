using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDMS.Class.DBClass
{
    public class AddressByContactClass
    {
        public int _AddrCont_Key { get; set; }
        public string _AddrCont_Address_NO { get; set; }
        public string _AddrCont_Address_Moo { get; set; }
        public string _AddrCont_Address_Soi { get; set; }
        public string _AddrCont_Address_Street { get; set; }
        public int _AddrCont_Address_District { get; set; }
        public int _AddrCont_Address_Amphur { get; set; }
        public int _AddrCont_Address_Province { get; set; }
        public int _AddrCont_Address_ZipCode { get; set; }
        public string _AddrCont_Telelphone { get; set; }
        public DateTime _AddrCont_CreateDateTime { get; set; }
        public string _AddrCont_CreateBy { get; set; }
        public DateTime _AddrCont_ModifyDateTime { get; set; }
        public string _AddrCont_ModifyBy { get; set; }
        public string _AddrCont_Status { get; set; }
        public string _AddrCont_Del { get; set; }
        public int _Emp_Key { get; set; }
    }
}
