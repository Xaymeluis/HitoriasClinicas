using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace HistoriasClinicas
{
    public partial class FormHistoria : Form
    {
        int idpaciente;
        bool FlagEditar = false;

        public FormHistoria()
        {
            InitializeComponent();
            EstateForm(false);
            ButtonNuevo.Enabled = true;
            ButtonBuscarPaciente.Enabled = true;
        }

        private void ClearForm()
        {
            FlagEditar = false;
            idpaciente = 0;
            TextBoxApellidoPaterno.Text = "";
            TextBoxApellidoMaterno.Text = "";
            TextBoxNombres.Text = "";
            DateTimeFechaNacimiento.Value = DateTime.Today;
            TextBoxDireccion.Text = "";
            TextBoxTelefono.Text = "";
            LabelHistoria.Text = idpaciente.ToString();
            CheckMostrarConsultas.Checked = false;
            CheckMostrarConsultas.Text = "Mostar todas";
            panel1.Visible = false;
            DataGridCitas.Rows.Clear();            
        }

        private void EstateForm(bool Estate)
        {
            TextBoxApellidoPaterno.Enabled = Estate;
            TextBoxApellidoMaterno.Enabled = Estate;
            TextBoxNombres.Enabled = Estate;
            DateTimeFechaNacimiento.Enabled = Estate;
            TextBoxDireccion.Enabled = Estate;
            TextBoxTelefono.Enabled = Estate;
            DataGridCitas.Enabled = Estate;
            ButtonNuevo.Enabled = Estate;
            ButtonBuscarPaciente.Enabled = Estate;
            ButtonAgregarConsulta.Enabled = Estate;
            ButtonGrabar.Enabled = Estate;
            ButtonCancelar.Enabled = Estate;
            ButtonEditar.Enabled = Estate;
            CheckMostrarConsultas.Enabled = Estate;
        }

        private void ButtonNuevo_Click(object sender, EventArgs e)
        {
            ClearForm();
            EstateForm(true);
            TextBoxApellidoPaterno.Focus();
            CheckMostrarConsultas.Enabled = false;
            ButtonAgregarConsulta.Enabled = false;
            ButtonBuscarPaciente.Enabled = false;
            ButtonEditar.Enabled = false;
            ButtonNuevo.Enabled = false;
        }

        private void ButtonGrabar_Click(object sender, EventArgs e)
        {
            if(TextBoxApellidoPaterno.Text.Trim() != "" &&
               TextBoxApellidoMaterno.Text.Trim() != "" &&
               TextBoxNombres.Text.Trim() != "" &&
               DateTimeFechaNacimiento.Value < DateTime.Today &&
               TextBoxDireccion.Text.Trim() != "" &&
               TextBoxTelefono.Text.Trim() != "")
            {
                ClassPaciente Paciente = ClassPaciente.SetPaciente(idpaciente
                                                                   , TextBoxApellidoPaterno.Text.Trim()
                                                                   , TextBoxApellidoMaterno.Text.Trim()
                                                                   , TextBoxNombres.Text.Trim()
                                                                   , DateTimeFechaNacimiento.Value
                                                                   , TextBoxDireccion.Text.Trim()
                                                                   , TextBoxTelefono.Text.Trim());
                if(FlagEditar)
                {
                    if (ClassPaciente.AlterPaciente(Paciente))
                    {
                        EstateForm(false);
                        idpaciente = Paciente.IdPaciente;
                        LabelHistoria.Text = idpaciente.ToString();
                        ButtonAgregarConsulta.Enabled = true;
                        ButtonCancelar.Enabled = true;
                    }
                }
                else
                {
                    if (ClassPaciente.AddPaciente(Paciente))
                    {
                        EstateForm(false);
                        idpaciente = ClassPaciente.GetLastPaciente();
                        LabelHistoria.Text = idpaciente.ToString();
                        ButtonAgregarConsulta.Enabled = true;
                        ButtonCancelar.Enabled = true;
                    }
                }
            }
        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonBuscarPaciente_Click(object sender, EventArgs e)
        {            
            FormBuscar Buscar = new FormBuscar
            {
                Busqueda = "Paciente"
            };
            if (Buscar.ShowDialog() == DialogResult.OK && Buscar.Result != 0)
            {
                idpaciente = Buscar.Result;                
                LoadDataToForm(ClassPaciente.LoadPaciente(idpaciente));
                LoadCitastoToform(ClassConsulta.GetConsultas(idpaciente));
                LabelHistoria.Text = idpaciente.ToString();
                DataGridCitas.Enabled = true;
                ButtonEditar.Enabled = true;
                CheckMostrarConsultas.Enabled = true;
            }            
        }

        private void LoadDataToForm(ClassPaciente Paciente)
        {
            ClearForm();
            idpaciente = Paciente.IdPaciente;
            TextBoxApellidoPaterno.Text = Paciente.ApellidoPaterno;
            TextBoxApellidoMaterno.Text = Paciente.ApellidoMaterno;
            TextBoxNombres.Text = Paciente.Nombres;
            DateTimeFechaNacimiento.Value = Convert.ToDateTime(Paciente.FechaNacimiento);
            TextBoxDireccion.Text = Paciente.Direccion;
            TextBoxTelefono.Text = Paciente.Telefono;
            EstateForm(false);
            ButtonAgregarConsulta.Enabled = true;
        }

        private void LoadCitastoToform(List<ClassConsulta> Consultas)
        {
            CheckMostrarConsultas.Text = $"Mostar todas ({Consultas.Count})";
            panel1.Visible = true;
            progressBar1.Minimum = 0;                        
            ButtonAgregarConsulta.Enabled = false;
            DataGridCitas.Rows.Clear();
            int CorrelativoConsulta = 1;
            List<ClassConsulta> MostrarConsulta = new List<ClassConsulta>();

            if (CheckMostrarConsultas.Checked)
            {
                MostrarConsulta = Consultas;
            }
            else
            {
                MostrarConsulta = Consultas.FindAll(x => x.IdCita == Consultas.Max(x1 => x1.IdCita));
            }

            progressBar1.Maximum = MostrarConsulta.Count;

            foreach (ClassConsulta Consulta in MostrarConsulta)
            {
                string PrintConsuta = string.Format("Fecha de Consulta: {0:D}                             Consulta # {6}{5}" +
                                                    "-------------------------------------------{5}" +
                                                    "Tiempo de enfermedad: {1}{5}" +
                                                    "-------------------------------------------{5}" +
                                                    "Detalle Atención: {5}" +
                                                    "{2}{5}" +
                                                    "-------------------------------------------{5}" +
                                                    "Tratamineto:{5}" +
                                                    "{3}{5}" +
                                                    "-------------------------------------------{5}" +
                                                    "Diagnosticos:{5}" +
                                                    "{4}{5}", Consulta.FechaConsulta
                                                    , Consulta.TiempoEnfermedad
                                                    , Consulta.DetalleAtencion
                                                    , Consulta.Tratamiento
                                                    , ClassDiagnostico.GetDiagnosticosInCita(Consulta.IdCita)
                                                    , Environment.NewLine
                                                    , (CorrelativoConsulta++).ToString("000")); ;
                DataGridCitas.Rows.Add(Consulta.IdCita, PrintConsuta);
                DataGridCitas.Enabled = true;
                progressBar1.PerformStep();
            }            
            ButtonAgregarConsulta.Enabled = true;
            panel1.Visible = false;
        }

        private void ButtonAgregarConsulta_Click(object sender, EventArgs e)
        {
            FormConsulta Consulta = new FormConsulta
            {
                IdPaciente = idpaciente
            };
            Consulta.ShowDialog();
            ButtonNuevo.Enabled = true;
            LoadCitastoToform(ClassConsulta.GetConsultas(idpaciente));
        }

        private void FormHistoria_Load(object sender, EventArgs e)
        {
            FormIngreso Ingreso = new FormIngreso();
            Ingreso.ShowDialog();
            if (!Ingreso.Ingreso) Close();
            DataGridViewTextBoxColumn NewColummCodigo = new DataGridViewTextBoxColumn
            {
                HeaderText = "IdCita",
                Visible = false
            };
            DataGridCitas.Columns.Add(NewColummCodigo);

            DataGridViewTextBoxColumn NewColummNombre = new DataGridViewTextBoxColumn
            {
                HeaderText = "Cita",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            DataGridCitas.Columns.Add(NewColummNombre);
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            ClearForm();
            EstateForm(false);
            ButtonBuscarPaciente.Enabled = true;
            ButtonNuevo.Enabled = true; 
        }

        private void ButtonEditar_Click(object sender, EventArgs e)
        {
            FlagEditar = true;
            EstateForm(true);
            ButtonAgregarConsulta.Enabled = false;
            ButtonBuscarPaciente.Enabled = false;
        }

        private void DataGridCitas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridCitas.CurrentRow != null && FlagEditar == true)
            {
                FormConsulta Consulta = new FormConsulta
                {
                    IdPaciente = idpaciente,
                    IdCita = Convert.ToInt32(DataGridCitas.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    FlagActualiza = true
                };
                Consulta.ShowDialog();
                LoadCitastoToform(ClassConsulta.GetConsultas(idpaciente));
                EstateForm(false);
                ButtonAgregarConsulta.Enabled = true;
                ButtonCancelar.Enabled = true;
                ButtonEditar.Enabled = true;
                ButtonNuevo.Enabled = true;
                FlagEditar = false;
            }
        }

        private void CheckMostrarConsultas_Click(object sender, EventArgs e)
        {
            LoadCitastoToform(ClassConsulta.GetConsultas(idpaciente));
        }
    }
}
