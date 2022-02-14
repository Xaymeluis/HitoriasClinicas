
namespace HistoriasClinicas
{
    partial class FormIngreso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIngreso));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxUsuario = new System.Windows.Forms.TextBox();
            this.TextBoxClave = new System.Windows.Forms.TextBox();
            this.ButtonIngreso = new System.Windows.Forms.Button();
            this.ButtonSalida = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Clave:";
            // 
            // TextBoxUsuario
            // 
            this.TextBoxUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxUsuario.Location = new System.Drawing.Point(208, 38);
            this.TextBoxUsuario.Name = "TextBoxUsuario";
            this.TextBoxUsuario.Size = new System.Drawing.Size(207, 20);
            this.TextBoxUsuario.TabIndex = 1;
            this.TextBoxUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxClave
            // 
            this.TextBoxClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxClave.Location = new System.Drawing.Point(208, 86);
            this.TextBoxClave.Name = "TextBoxClave";
            this.TextBoxClave.PasswordChar = '#';
            this.TextBoxClave.Size = new System.Drawing.Size(207, 20);
            this.TextBoxClave.TabIndex = 2;
            this.TextBoxClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxClave_KeyPress);
            // 
            // ButtonIngreso
            // 
            this.ButtonIngreso.BackColor = System.Drawing.Color.White;
            this.ButtonIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonIngreso.Location = new System.Drawing.Point(208, 122);
            this.ButtonIngreso.Name = "ButtonIngreso";
            this.ButtonIngreso.Size = new System.Drawing.Size(100, 23);
            this.ButtonIngreso.TabIndex = 3;
            this.ButtonIngreso.Text = "Ingresar";
            this.ButtonIngreso.UseVisualStyleBackColor = false;
            this.ButtonIngreso.Click += new System.EventHandler(this.ButtonIngreso_Click);
            // 
            // ButtonSalida
            // 
            this.ButtonSalida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonSalida.Location = new System.Drawing.Point(315, 122);
            this.ButtonSalida.Name = "ButtonSalida";
            this.ButtonSalida.Size = new System.Drawing.Size(100, 23);
            this.ButtonSalida.TabIndex = 4;
            this.ButtonSalida.Text = "Salir";
            this.ButtonSalida.UseVisualStyleBackColor = true;
            this.ButtonSalida.Click += new System.EventHandler(this.ButtonSalida_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HistoriasClinicas.Properties.Resources._01;
            this.pictureBox1.Location = new System.Drawing.Point(2, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(425, 177);
            this.Controls.Add(this.ButtonSalida);
            this.Controls.Add(this.ButtonIngreso);
            this.Controls.Add(this.TextBoxClave);
            this.Controls.Add(this.TextBoxUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormIngreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxUsuario;
        private System.Windows.Forms.TextBox TextBoxClave;
        private System.Windows.Forms.Button ButtonIngreso;
        private System.Windows.Forms.Button ButtonSalida;
    }
}