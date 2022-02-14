using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HistoriasClinicas
{
    public partial class FormBuscar : Form
    {
        public string Busqueda;

        public int Result { get; set; } 

        List<ClassBusqueda> ResultadoBusqueda = new List<ClassBusqueda>();

        public FormBuscar()
        {
            InitializeComponent();
            Result = 0;
        }

        private void FormBuscar_Load(object sender, EventArgs e)
        {
            ResultadoBusqueda = ClassBusqueda.GetKeyValue(Busqueda);
            DataGridViewTextBoxColumn NewColummValue = new DataGridViewTextBoxColumn
            {
                HeaderText = Busqueda,
                Width = 439
            };
            DataGridResultado.Columns.Add(NewColummValue);

            DataGridViewTextBoxColumn NewColummId = new DataGridViewTextBoxColumn
            {
                HeaderText = "Id",
                Width = 10,
                Visible = false
            };
            DataGridResultado.Columns.Add(NewColummId);

        }

        private void LoadDataGrid(List<ClassBusqueda> Resultado)
        {
            DataGridResultado.Rows.Clear();
            DataGridResultado.Refresh();
            foreach (var Key in Resultado)
            {
                DataGridResultado.Rows.Add(Key.Value, Key.Id);
                
            }
        }

        private void FilterResults(List<ClassBusqueda> Resultado, string Filter)
        {
            List<ClassBusqueda> filteredList = Resultado.Where(x => x.Value.Contains(Filter)).ToList();
            LoadDataGrid(filteredList);
        }

        private void TextBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxBuscar.Text.Trim() != "")
            {
                FilterResults(ResultadoBusqueda, TextBoxBuscar.Text.Trim());
            }
            else
            {
                DataGridResultado.Rows.Clear();
                DataGridResultado.Refresh();
            }
        }

        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            Result = GetSelctedId(DataGridResultado.CurrentCell.RowIndex);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private int GetSelctedId(int Index)
        {
            return (Index >= 0)? Convert.ToInt32(DataGridResultado.Rows[Index].Cells[1].Value.ToString()) : 0;
        }

        private void DataGridResultado_DoubleClick(object sender, EventArgs e)
        {
            Result = GetSelctedId(DataGridResultado.CurrentCell.RowIndex);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
