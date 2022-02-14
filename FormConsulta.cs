using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HistoriasClinicas
{
    public partial class FormConsulta : Form
    {        
        public int IdPaciente { get; set; }
        public int IdCita { get; set; }
        public bool FlagActualiza { get; set; }

        public FormConsulta()
        {
            InitializeComponent();
        }

        private void FormConsulta_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn NewColummCodigo = new DataGridViewTextBoxColumn
            {
                HeaderText = "Codigo",
                ReadOnly = true,
            };
            DataGridDiagnostico.Columns.Add(NewColummCodigo);

            DataGridViewTextBoxColumn NewColummNombre = new DataGridViewTextBoxColumn
            {
                HeaderText = "Detalle",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                ReadOnly = true,
            };
            DataGridDiagnostico.Columns.Add(NewColummNombre);

            DataGridViewTextBoxColumn NewColummid = new DataGridViewTextBoxColumn
            {
                HeaderText = "IdDiagnostico",               
                Visible = false
            };
            DataGridDiagnostico.Columns.Add(NewColummid);

            DataGridViewCheckBoxColumn NewColummType = new DataGridViewCheckBoxColumn
            {
                HeaderText = "Principal",
                Selected = false
            };
            DataGridDiagnostico.Columns.Add(NewColummType);
            LabelNombrePaciente.Text = ClassPaciente.GetPacienteNombre(IdPaciente);

            if(FlagActualiza)
            {
                ClassConsulta Consulta = ClassConsulta.GetCita(IdPaciente, IdCita);
                LoadDataToForm(Consulta);
            }
        }

        private void ButtonGrabar_Click(object sender, EventArgs e)
        {
            if (TextBoxTiempoEnfermedad.Text.Trim() != "" && TextBoxDetalleAtencion.Text.Trim() != "" && TextBoxTratamiento.Text.Trim() != "" )
            {
                if (FlagActualiza)
                {
                    ClassConsulta Consulta = new ClassConsulta
                    {
                        IdPaciente = IdPaciente,
                        IdCita = IdCita,
                        FechaConsulta = DateTimeFechaCita.Value,
                        TiempoEnfermedad = TextBoxTiempoEnfermedad.Text.Trim(),
                        DetalleAtencion = TextBoxDetalleAtencion.Text.Trim(),
                        Tratamiento = TextBoxTratamiento.Text.Trim()
                    };

                    if (ClassConsulta.UpateConsulta(Consulta))
                    {
                        ClassDiagnostico.RetiraDiagnosticos(IdCita);
                        if (DataGridDiagnostico.Rows.Count > 0)
                        {
                            foreach (DataGridViewRow Row in DataGridDiagnostico.Rows)
                            {
                                ClassDiagnostico.SaveDiagnostico(Consulta.IdCita, Convert.ToInt32(Row.Cells[2].Value.ToString()), (Row.Cells[3].Value != null ? "true" : "false"));
                            }
                        }
                    }
                }

                else
                {
                    if (ClassConsulta.SaveConsulta(IdPaciente, DateTimeFechaCita.Value, TextBoxTiempoEnfermedad.Text.Trim(), TextBoxDetalleAtencion.Text.Trim(), TextBoxTratamiento.Text.Trim()))
                    {
                        if (DataGridDiagnostico.Rows.Count > 0)
                        {
                            foreach (DataGridViewRow Row in DataGridDiagnostico.Rows)
                            {
                                ClassDiagnostico.SaveDiagnostico((ClassConsulta.GetLastConsulta()), Convert.ToInt32(Row.Cells[2].Value.ToString()), (Row.Cells[3].Value != null ? "true" : "false"));
                            }
                        }
                    }
                }
                ClearData();
            }
        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearData()
        {
            TextBoxTiempoEnfermedad.Text = "";
            TextBoxDetalleAtencion.Text = "";
            TextBoxTratamiento.Text = "";
            DataGridDiagnostico.Rows.Clear();
            this.Close();
        }

        private void ButtonAnadirDiagnostico_Click(object sender, EventArgs e)
        {
            FormBuscar Buscar = new FormBuscar
            {
                Busqueda = "Diagnostico"
            };
            if (Buscar.ShowDialog() == DialogResult.OK && Buscar.Result != 0)
            {
                SetDiagnostico(Buscar.Result);
            }
        }

        private void SetDiagnostico(int Codigo)
        {            
            ClassDiagnostico Diagnostico = ClassDiagnostico.GetDiagnostico(Codigo);
            DataGridDiagnostico.Rows.Add(Diagnostico.CodigoDiagnostico, Diagnostico.Nobre, Diagnostico.IdDiagnsotico.ToString());
        }

        private void ButtonRetirarDiagnostico_Click(object sender, EventArgs e)
        {
            if (DataGridDiagnostico.CurrentRow == null)
                return;
            DataGridDiagnostico.Rows.Remove(DataGridDiagnostico.CurrentRow);
        }

        private void LoadDataToForm(ClassConsulta Consulta)
        {
            TextBoxTiempoEnfermedad.Text = Consulta.TiempoEnfermedad;
            TextBoxDetalleAtencion.Text = Consulta.DetalleAtencion;
            TextBoxTratamiento.Text = Consulta.Tratamiento;

            List<int> DiagnosticosAtencion = ClassDiagnostico.GetCodesDiagnosticosInCita(Consulta.IdCita);
            foreach(int diagnostico in DiagnosticosAtencion)
            {
                SetDiagnostico(diagnostico);
            }
        }
    }
}
