using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HistoriasClinicas;
using System.Data.OleDb;
using System.Windows.Forms;

namespace HistoriasClinicas
{
    class ClassUsuario
    {
        static string _nombreUsuario = "";
        static string _claveUsuario = "";

        private static void SetCredentials(string UserName)
        {            
            try
            {
                using (OleDbConnection ConnectionOleDb= ClassConection.ConnectionOleDb())
                {
                    OleDbCommand CommandOleDb = new OleDbCommand(string.Format("Select NombreUsuario, ClaveUsuario from usuario where NombreUsuario = '{0}'", UserName), ConnectionOleDb);
                    OleDbDataReader Reader = CommandOleDb.ExecuteReader();
                    while(Reader.Read())
                    {
                        _nombreUsuario = Reader[0].ToString();
                        _claveUsuario = Reader[1].ToString();
                    }
                }

            }
            catch(Exception Ex)
            {
                ClassShowMessage.UserError("Error al obtener datos " + Ex);
            }
        }

        public static bool ValidUser(string NombreUsuario, string ClaveUsuario)
        {
            SetCredentials(NombreUsuario);
            return (NombreUsuario.ToUpper() == _nombreUsuario.ToUpper() && ClaveUsuario.ToUpper() == _claveUsuario.ToUpper())? true: false;
        }
       
    }
}
