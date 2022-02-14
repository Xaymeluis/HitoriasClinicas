using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace HistoriasClinicas
{
    public class ClassPaciente
    {
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Nombres { get; set; }
        public string NombreCompleto { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaCreación { get; set; }
        public int IdPaciente { get; set; }

        public ClassPaciente() { }

        public static ClassPaciente SetPaciente(int IdPaciente, string ApellidoPaterno, string ApellidoMaterno, string Nombres, DateTime FechaNacimiento, string Direccion, string Telefono) 
        {
            ClassPaciente Paciente = new ClassPaciente
            {
                IdPaciente = IdPaciente,
                ApellidoPaterno = ApellidoPaterno.Trim(),
                ApellidoMaterno = ApellidoMaterno.Trim(),
                Nombres = Nombres.Trim(),
                NombreCompleto = string.Format("{0} {1} {2}", ApellidoPaterno, ApellidoMaterno, Nombres),
                FechaNacimiento = FechaNacimiento,
                Direccion = Direccion.Trim(),
                Telefono = Telefono.Trim(),
                FechaCreación = DateTime.Today
            };
            return Paciente;
        }

        public static bool AddPaciente(ClassPaciente Paciente)
        {
            try
            {
                using (OleDbConnection ConnectionOleDb = ClassConection.ConnectionOleDb())
                {
                    OleDbCommand CommandOleDb = new OleDbCommand(string.Format("Insert Into Paciente(ApellidoPaterno, ApellidoMaterno, Nombres, NombreCompleto, FechaNacimiento, Direccion, Telefonos, FechaCreacion) " +
                                                                               "values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}');",
                                                                               Paciente.ApellidoPaterno,
                                                                               Paciente.ApellidoMaterno,
                                                                               Paciente.Nombres,
                                                                               Paciente.NombreCompleto,
                                                                               Paciente.FechaNacimiento,
                                                                               Paciente.Direccion,
                                                                               Paciente.Telefono,
                                                                               Paciente.FechaCreación),ConnectionOleDb);
                    return CommandOleDb.ExecuteNonQuery() == 1;
                }
            }
            catch(Exception Ex)
            {
                ClassShowMessage.UserError("Error al Grabar los Datos " + Ex);
            }
            return false;
        }

        public static ClassPaciente LoadPaciente(int IdPaciente)
        {
            ClassPaciente Paciente = new ClassPaciente(); ;
            try
            {
                using (OleDbConnection ConnectionOleDb = ClassConection.ConnectionOleDb())
                {
                    OleDbCommand CommandOleDb = new OleDbCommand(string.Format("Select Idpaciente, ApellidoPaterno, ApellidoMaterno, Nombres, FechaNacimiento, Direccion, Telefonos from paciente where Idpaciente = {0};",
                                                                               IdPaciente), ConnectionOleDb);
                    OleDbDataReader Reader = CommandOleDb.ExecuteReader();
                    if(Reader.HasRows)
                    {
                        while (Reader.Read())
                        {                            
                            Paciente = SetPaciente(Convert.ToInt32(Reader[0].ToString()), Reader[1].ToString(), Reader[2].ToString(), Reader[3].ToString(), Convert.ToDateTime(Reader[4].ToString()), Reader[5].ToString(), Reader[6].ToString());
                            Paciente.IdPaciente = IdPaciente;
                        }
                        return Paciente; 
                    }
                    else
                    {
                        throw new Exception("Error al cargar los datos");
                    }
                }
            }
            catch (Exception Ex)
            {
                ClassShowMessage.UserError("Error al Cargar Datos del Paciente" + Ex);
            }          
            return Paciente;
        }

        public static bool AlterPaciente(ClassPaciente Paciente)
        {            
            try
            {
                using (OleDbConnection ConnectionOleDb = ClassConection.ConnectionOleDb())
                {
                    OleDbCommand CommandOleDb = new OleDbCommand(string.Format("Update Paciente set ApellidoPaterno = '{1}', ApellidoMaterno = '{2}', Nombres = '{3}', NombreCompleto = '{4}', FechaNacimiento = '{5}', Direccion = '{6}', Telefonos = '{7}', FechaCreacion = '{8}' where Idpaciente = {0};",
                                                                               Paciente.IdPaciente
                                                                               , Paciente.ApellidoPaterno
                                                                               , Paciente.ApellidoMaterno
                                                                               , Paciente.Nombres
                                                                               , Paciente.NombreCompleto
                                                                               , Paciente.FechaNacimiento
                                                                               , Paciente.Direccion
                                                                               , Paciente.Telefono
                                                                               , Paciente.FechaCreación), ConnectionOleDb);
                    return CommandOleDb.ExecuteNonQuery() == 1;                    
                }
            }
            catch (Exception Ex)
            {
                ClassShowMessage.UserError("Error al Actualizar los Datos del Paciente" + Ex);
            }
            return false;
        }

        public static int GetLastPaciente()
        {
            try
            {
                using (OleDbConnection ConnectionOleDb = ClassConection.ConnectionOleDb())
                {
                    OleDbCommand CommandOleDb = new OleDbCommand(string.Format("SELECT max(idpaciente) from paciente;"), ConnectionOleDb);
                    OleDbDataReader Reader = CommandOleDb.ExecuteReader();
                    if (Reader.HasRows)
                    {
                        while (Reader.Read())
                        {
                            return Convert.ToInt32(Reader[0].ToString());
                        }
                    }
                    else
                    {
                        ClassShowMessage.UserError("Error al Obtener la Información");
                    }
                }
            }
            catch (Exception Ex)
            {
                ClassShowMessage.UserError("Error al Actualizar los Datos del Paciente" + Ex);
                return 0;
            }            
            return 0;
        }

        public static string GetPacienteNombre(int idPaciente)
        {
            string Nombre = "";
            try
            {
                using (OleDbConnection ConnectionOleDb = ClassConection.ConnectionOleDb())
                {
                    OleDbCommand CommandOleDb = new OleDbCommand(string.Format("SELECT NombreCompleto from paciente where IdPaciente = {0};", idPaciente), ConnectionOleDb);
                    OleDbDataReader Reader = CommandOleDb.ExecuteReader();
                    if (Reader.HasRows)
                    {
                        while (Reader.Read())
                        {
                            Nombre = Reader[0].ToString();
                        }
                    }
                    else
                    {
                        ClassShowMessage.UserError("Error al Obtener la Información");
                    }
                }
            }
            catch (Exception Ex)
            {
                ClassShowMessage.UserError("Error al Actualizar los Datos del Paciente" + Ex);
                return "";
            }
            return Nombre;
        }
    }
}
