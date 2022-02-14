using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace HistoriasClinicas
{
    class ClassDiagnostico
    {
        public int IdDiagnsotico { get; set; }
        public string CodigoDiagnostico { get; set; }
        public string Nobre { get; set; }

        public static ClassDiagnostico GetDiagnostico(int Codigo)
        {
            ClassDiagnostico Diagnostico = new ClassDiagnostico();
            try
            {
                using (OleDbConnection ConnectionOleDb = ClassConection.ConnectionOleDb())
                {
                    OleDbCommand CommandOleDb = new OleDbCommand(string.Format("SELECT IdDiagnostico, CodigoDiagnostico, Nombre from Diagnostico where IdDiagnostico = {0};", Codigo), ConnectionOleDb);
                    OleDbDataReader Reader = CommandOleDb.ExecuteReader();
                    if (Reader.HasRows)
                    {
                        while (Reader.Read())
                        {
                            Diagnostico.IdDiagnsotico = Convert.ToInt32(Reader[0].ToString());
                            Diagnostico.CodigoDiagnostico = Reader[1].ToString();
                            Diagnostico.Nobre = Reader[2].ToString();
                        }
                    }
                    else
                    {
                        ClassShowMessage.UserError("No se Encontraron Datos ");
                    }
                }
            }
            catch(Exception Ex)
            {
                ClassShowMessage.UserError("Error al Obtener Diagnostico" + Ex);
            }
            return Diagnostico;
        }

        public ClassDiagnostico() { }

        public static void SaveDiagnostico(int IdCita, int IdDiagnostico, string Tipo)
        {            
            try
            {
                using (OleDbConnection ConnectionOleDb = ClassConection.ConnectionOleDb())
                {
                    OleDbCommand CommandOleDb = new OleDbCommand(string.Format("INSERT INTO DiagnosticoCita (IdCita, IdDiagnostico, Tipo) values ({0},{1},'{2}')"
                                                                               , IdCita
                                                                               , IdDiagnostico
                                                                               , Tipo), ConnectionOleDb);
                    CommandOleDb.ExecuteNonQuery();
                }
            }
            catch (Exception Ex)
            {
                ClassShowMessage.UserError("Error al Obtener Diagnostico" + Ex);
            }            
        }

        public static string GetDiagnosticosInCita(int IdCita)
        {
            string diagnosticos = "";
            try
            {
                using (OleDbConnection ConnectionOleDb = ClassConection.ConnectionOleDb())
                {
                    OleDbCommand CommandOleDb = new OleDbCommand(string.Format("SELECT Diagnostico.CodigoDiagnostico, Diagnostico.Nombre, DiagnosticoCita.IdCita " +
                                                                               "FROM Diagnostico INNER JOIN DiagnosticoCita ON Diagnostico.IdDiagnostico = DiagnosticoCita.IdDiagnostico " +
                                                                               "WHERE(((DiagnosticoCita.IdCita) = {0}));"
                                                                               , IdCita), ConnectionOleDb);
                    OleDbDataReader Reader = CommandOleDb.ExecuteReader();
                    if (Reader.HasRows)
                    {
                        while(Reader.Read())
                        {
                            diagnosticos += string.Format("- {0} - {1}{2}"
                                                          , Reader[0].ToString().Trim()
                                                          , Reader[1].ToString().Trim()
                                                          , Environment.NewLine);
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                ClassShowMessage.UserError("Error al Obtener Diagnostico" + Ex);
            }
            return diagnosticos;
        }

        public static List<int> GetCodesDiagnosticosInCita(int IdCita)
        {
            List<int> Codigos = new List<int>();
            try
            {
                using (OleDbConnection ConnectionOleDb = ClassConection.ConnectionOleDb())
                {
                    OleDbCommand CommandOleDb = new OleDbCommand(string.Format("SELECT DiagnosticoCita.IdDiagnostico FROM DiagnosticoCita WHERE (((DiagnosticoCita.IdCita)={0}));"
                                                                               , IdCita), ConnectionOleDb);
                    OleDbDataReader Reader = CommandOleDb.ExecuteReader();
                    if (Reader.HasRows)
                    {
                        while (Reader.Read())
                        {
                            Codigos.Add(Convert.ToInt32(Reader[0].ToString()));
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                ClassShowMessage.UserError("Error al Obtener Diagnostico" + Ex);
            }
            return Codigos;
        }

        public static bool RetiraDiagnosticos(int IdCita)
        {            
            try
            {
                using (OleDbConnection ConnectionOleDb = ClassConection.ConnectionOleDb())
                {
                    OleDbCommand CommandOleDb = new OleDbCommand(string.Format("DELETE FROM DiagnosticoCita WHERE IdCita = {0};"
                                                                               , IdCita), ConnectionOleDb); 
                    return (CommandOleDb.ExecuteNonQuery() == 1);
                }
            }
            catch (Exception Ex)
            {
                ClassShowMessage.UserError("Error al Obtener Diagnostico" + Ex);
            }
            return false;
        }
    }
}
