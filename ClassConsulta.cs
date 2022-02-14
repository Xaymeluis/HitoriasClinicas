using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace HistoriasClinicas
{
    class ClassConsulta
    {
        public int IdCita { get; set; }
        public int IdPaciente { get; set; }
        public DateTime FechaConsulta { get; set; }
        public string TiempoEnfermedad { get; set; }
        public string DetalleAtencion { get; set; }
        public string Tratamiento { get; set; }

        public ClassConsulta() { }

        public static bool SaveConsulta(int IdPaciente, DateTime FechaConsulta, string TiempoEnfermedad, string DetalleAtencion, string Tratamiento)        
        {
            using (OleDbConnection ConnectionOleDb = ClassConection.ConnectionOleDb())
            {
                try
                {
                    OleDbCommand CommandOleDb = new OleDbCommand(string.Format("Insert Into cita (IdPaciente, FechaCita, TiempoDeEnfermedad, DetalleAtencion, Tratamiento)" +
                                                                               "values('{0}','{1}','{2}','{3}','{4}')", IdPaciente
                                                                               , FechaConsulta
                                                                               , TiempoEnfermedad
                                                                               , DetalleAtencion
                                                                               , Tratamiento), ConnectionOleDb);
                    return CommandOleDb.ExecuteNonQuery() == 1;
                }
                catch(Exception Ex)
                {
                    ClassShowMessage.UserError("Error al Registrar Datos de Consulta" + Ex);
                }
            }
            return false;
        }

        public static List<ClassConsulta> GetConsultas(int IdPaciente)
        {
            List<ClassConsulta> Consultas = new List<ClassConsulta>();

            using (OleDbConnection ConnectionOleDb = ClassConection.ConnectionOleDb())
            {
                try
                {
                    OleDbCommand CommandOleDb = new OleDbCommand(string.Format("SELECT Cita.IdCita, Cita.IdPaciente, Cita.FechaCita, Cita.TiempoDeEnfermedad, Cita.DetalleAtencion, Cita.Tratamiento FROM Cita WHERE Cita.IDPaciente = {0};"
                                                                               , IdPaciente), ConnectionOleDb);
                    OleDbDataReader Reader = CommandOleDb.ExecuteReader();
                    if (Reader.HasRows)
                    {
                        while(Reader.Read())
                        {
                            ClassConsulta consulta = new ClassConsulta();
                            consulta.IdCita = Convert.ToInt32(Reader[0].ToString());
                            consulta.IdPaciente = Convert.ToInt32(Reader[1].ToString());
                            consulta.FechaConsulta = Convert.ToDateTime(Reader[2].ToString());
                            consulta.TiempoEnfermedad = Reader[3].ToString();
                            consulta.DetalleAtencion = Reader[4].ToString();
                            consulta.Tratamiento = Reader[5].ToString();
                            Consultas.Add(consulta);
                        }
                    }
                    else
                    {
                        ClassShowMessage.UserError("No Existendatos Consultas Anteriores");
                    }
                    
                }
                catch (Exception Ex)
                {
                    ClassShowMessage.UserError("Error al Registrar Datos de Consulta" + Ex);
                }
            }
            return Consultas;
        }

        public static int GetLastConsulta()
        {
            using (OleDbConnection ConnectionOleDb = ClassConection.ConnectionOleDb())
            {
                try
                {
                    OleDbCommand CommandOleDb = new OleDbCommand(string.Format("SELECT MAX(IdCita) from Cita"), ConnectionOleDb);
                    OleDbDataReader Reader = CommandOleDb.ExecuteReader();
                    if(Reader.HasRows)
                    {
                        while(Reader.Read())
                        {
                            return Convert.ToInt32(Reader[0].ToString());
                        }
                    }
                }
                catch (Exception Ex)
                {
                    ClassShowMessage.UserError("Error al Registrar Datos de Consulta" + Ex);
                }
            }
            return 0;
        }

        public static ClassConsulta GetCita(int IdPaciente, int IdCita)
        {
            ClassConsulta Consulta = new ClassConsulta();

            using (OleDbConnection ConnectionOleDb = ClassConection.ConnectionOleDb())
            {
                try
                {
                    OleDbCommand CommandOleDb = new OleDbCommand(string.Format("SELECT Cita.IdCita, Cita.IDPaciente, Cita.FechaCita, Cita.TiempoDeEnfermedad, Cita.DetalleAtencion, Cita.Tratamiento FROM Cita WHERE Cita.IdCita = {0} AND Cita.IDPaciente = {1};"
                                                                               , IdCita
                                                                               , IdPaciente), ConnectionOleDb);
                    OleDbDataReader Reader = CommandOleDb.ExecuteReader();
                    if (Reader.HasRows)
                    {
                        while (Reader.Read())
                        {
                            Consulta.IdCita = Convert.ToInt32(Reader[0].ToString());
                            Consulta.IdPaciente = Convert.ToInt32(Reader[1].ToString());
                            Consulta.FechaConsulta = Convert.ToDateTime(Reader[2].ToString());
                            Consulta.TiempoEnfermedad = Reader[3].ToString();
                            Consulta.DetalleAtencion = Reader[4].ToString();
                            Consulta.Tratamiento = Reader[5].ToString();
                        }
                    }
                }
                catch (Exception Ex)
                {
                    ClassShowMessage.UserError("Error al Registrar Datos de Consulta" + Ex);
                }
            }
            return Consulta;
        }

        public static bool UpateConsulta(ClassConsulta Consulta)
        {
            using (OleDbConnection ConnectionOleDb = ClassConection.ConnectionOleDb())
            {
                try
                {
                    OleDbCommand CommandOleDb = new OleDbCommand(string.Format("UPDATE cita Set FechaCita = '{2}', TiempoDeEnfermedad = '{3}', DetalleAtencion = '{4}', Tratamiento = '{5}' " +
                                                                               "WHERE IdPaciente = {0} and IdCita = {1};"
                                                                               , Consulta.IdPaciente
                                                                               , Consulta.IdCita
                                                                               , Consulta.FechaConsulta
                                                                               , Consulta.TiempoEnfermedad
                                                                               , Consulta.DetalleAtencion
                                                                               , Consulta.Tratamiento), ConnectionOleDb);
                    return CommandOleDb.ExecuteNonQuery() == 1;
                }
                catch (Exception Ex)
                {
                    ClassShowMessage.UserError("Error al Actualizar los Datos de Consulta" + Ex);
                }
            }
            return false;
        }

        public static ClassConsulta GetLastConsulta(int IdPaciente)
        {
            ClassConsulta Consulta = new ClassConsulta();
                        
            using (OleDbConnection ConnectionOleDb = ClassConection.ConnectionOleDb())
            {
                try
                {
                    OleDbCommand CommandOleDb = new OleDbCommand(string.Format("SELECT Cita.IdCita, Cita.IDPaciente, Cita.FechaCita, Cita.TiempoDeEnfermedad, Cita.DetalleAtencion, Cita.Tratamiento, Cita.IDPaciente " +
                                                                               "FROM Cita " +
                                                                               "WHERE Cita.IDPaciente = {0} " +
                                                                               "and Cita.IdCita = (select max(c.idcita)from cita as c where c.idpaciente = {0}); "
                                                                               , IdPaciente), ConnectionOleDb);
                    OleDbDataReader Reader = CommandOleDb.ExecuteReader();
                    if (Reader.HasRows)
                    {
                        while (Reader.Read())
                        {                            
                            Consulta.IdCita = Convert.ToInt32(Reader[0].ToString());
                            Consulta.IdPaciente = Convert.ToInt32(Reader[1].ToString());
                            Consulta.FechaConsulta = Convert.ToDateTime(Reader[2].ToString());
                            Consulta.TiempoEnfermedad = Reader[3].ToString();
                            Consulta.DetalleAtencion = Reader[4].ToString();
                            Consulta.Tratamiento = Reader[5].ToString();                            
                        }
                    }
                    else
                    {
                        ClassShowMessage.UserError("No Existendatos Consultas Anteriores");
                    }

                }
                catch (Exception Ex)
                {
                    ClassShowMessage.UserError("Error al Registrar Datos de Consulta" + Ex);
                }
            }
            return Consulta;
        }
    }
}
