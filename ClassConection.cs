using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace HistoriasClinicas
{
    class ClassConection
    {
        public static OleDbConnection ConnectionOleDb()
        {
            OleDbConnection _conecctionOleDb = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=" + Path.GetFullPath("DataBAse.accdb") + ";User ID=Admin;Password=");            
            _conecctionOleDb.Open(); 
            return _conecctionOleDb;
        }

    }
}
