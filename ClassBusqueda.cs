using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Data.OleDb;
using System.Windows.Forms;

namespace HistoriasClinicas
{
    class ClassBusqueda
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public string Value2 { get; set; }

        public ClassBusqueda() { }

        public static List<ClassBusqueda> GetKeyValue(string Table)
        {
            List<ClassBusqueda> KeyValue = new List<ClassBusqueda>();

            string SqlQuery = "";

            if (Table == "Paciente") SqlQuery = string.Format("Select IdPaciente, NombreCompleto from Paciente;");
            if (Table == "Diagnostico") SqlQuery = string.Format("SELECT IdDiagnostico, CodigoDiagnostico + ' - ' + Nombre AS Diagnostico FROM Diagnostico; ");

            if (SqlQuery != "")
            {
                using (OleDbConnection ConnectionOleDb = ClassConection.ConnectionOleDb())
                {
                    try         
                    {
                        OleDbCommand CommandOleDb = new OleDbCommand(SqlQuery, ConnectionOleDb);
                        OleDbDataReader Reader = CommandOleDb.ExecuteReader();
                        if (Reader.HasRows)
                        {
                            while(Reader.Read())
                            {
                                ClassBusqueda _keyValue = new ClassBusqueda();
                                _keyValue.Id = Convert.ToInt32(Reader[0].ToString());
                                _keyValue.Value = Reader[1].ToString();
                                KeyValue.Add(_keyValue);
                            }
                        }
                        else
                        {
                            ClassShowMessage.UserError("No se Encontraron datos ");
                        }
                    }
                    catch (Exception Ex)
                    {
                        ClassShowMessage.UserError("Error al obtener los Datos de Busqueda" + Ex);
                    }
                }
            }
            return KeyValue;
        }
    }
}
