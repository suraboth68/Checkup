using CDMS.Class.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDMS.Class.Function
{
    public static class GetMasterDataClass
    {
        public static DateTime GetDateServer()
        {
            var db = new CDMSDBDataContext(Program.conStr);

            return db.ExecuteQuery<DateTime>("SELECT GETDATE()").FirstOrDefault();
        }
    }
}
