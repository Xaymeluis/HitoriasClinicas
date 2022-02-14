using System;
using System.Windows.Forms;


namespace HistoriasClinicas
{
    public partial class FormIngreso : Form
    {
        public bool Ingreso { get; set; }

        public FormIngreso()
        {
            InitializeComponent();
            Ingreso = false;
        }

        private void ButtonIngreso_Click(object sender, EventArgs e)
        {
            if (TextBoxUsuario.Text.Trim() != "" || TextBoxClave.Text.Trim() != "")                 
                if (ClassUsuario.ValidUser(TextBoxUsuario.Text.Trim(), TextBoxClave.Text.Trim()))                
                {
                    Ingreso = true;
                    this.Hide();
                }
                else
                {
                    ClassShowMessage.UserError("Error en los datos de Ingreso");
                    Clear();
                }
        }

        private void ButtonSalida_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clear()
        {
            TextBoxUsuario.Text = "";
            TextBoxClave.Text = "";
            TextBoxUsuario.Focus();
        }

        private void TextBoxClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) ButtonIngreso.PerformClick(); 

        }
    }
}
