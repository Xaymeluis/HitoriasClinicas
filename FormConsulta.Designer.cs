
namespace HistoriasClinicas
{
    partial class FormConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsulta));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DateTimeFechaCita = new System.Windows.Forms.DateTimePicker();
            this.TextBoxTiempoEnfermedad = new System.Windows.Forms.TextBox();
            this.TextBoxDetalleAtencion = new System.Windows.Forms.TextBox();
            this.TextBoxTratamiento = new System.Windows.Forms.TextBox();
            this.DataGridDiagnostico = new System.Windows.Forms.DataGridView();
            this.ButtonGrabar = new System.Windows.Forms.Button();
            this.ButtonCancelar = new System.Windows.Forms.Button();
            this.ButtonAnadirDiagnostico = new System.Windows.Forms.Button();
            this.ButtonSalir = new System.Windows.Forms.Button();
            this.LabelNombrePaciente = new System.Windows.Forms.Label();
            this.ButtonRetirarDiagnostico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDiagnostico)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha de Cita";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tiempo de Enfermedad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Detalle Atención";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tratameinto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Diagnosticos";
            // 
            // DateTimeFechaCita
            // 
            this.DateTimeFechaCita.Location = new System.Drawing.Point(147, 41);
            this.DateTimeFechaCita.Name = "DateTimeFechaCita";
            this.DateTimeFechaCita.Size = new System.Drawing.Size(200, 20);
            this.DateTimeFechaCita.TabIndex = 5;
            // 
            // TextBoxTiempoEnfermedad
            // 
            this.TextBoxTiempoEnfermedad.Location = new System.Drawing.Point(147, 69);
            this.TextBoxTiempoEnfermedad.Name = "TextBoxTiempoEnfermedad";
            this.TextBoxTiempoEnfermedad.Size = new System.Drawing.Size(100, 20);
            this.TextBoxTiempoEnfermedad.TabIndex = 6;
            // 
            // TextBoxDetalleAtencion
            // 
            this.TextBoxDetalleAtencion.Location = new System.Drawing.Point(12, 113);
            this.TextBoxDetalleAtencion.Multiline = true;
            this.TextBoxDetalleAtencion.Name = "TextBoxDetalleAtencion";
            this.TextBoxDetalleAtencion.Size = new System.Drawing.Size(545, 106);
            this.TextBoxDetalleAtencion.TabIndex = 7;
            // 
            // TextBoxTratamiento
            // 
            this.TextBoxTratamiento.Location = new System.Drawing.Point(12, 243);
            this.TextBoxTratamiento.Multiline = true;
            this.TextBoxTratamiento.Name = "TextBoxTratamiento";
            this.TextBoxTratamiento.Size = new System.Drawing.Size(545, 93);
            this.TextBoxTratamiento.TabIndex = 8;
            // 
            // DataGridDiagnostico
            // 
            this.DataGridDiagnostico.AllowUserToAddRows = false;
            this.DataGridDiagnostico.AllowUserToDeleteRows = false;
            this.DataGridDiagnostico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridDiagnostico.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DataGridDiagnostico.Location = new System.Drawing.Point(12, 358);
            this.DataGridDiagnostico.Name = "DataGridDiagnostico";
            this.DataGridDiagnostico.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridDiagnostico.RowHeadersVisible = false;
            this.DataGridDiagnostico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridDiagnostico.Size = new System.Drawing.Size(406, 79);
            this.DataGridDiagnostico.TabIndex = 9;
            // 
            // ButtonGrabar
            // 
            this.ButtonGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonGrabar.Location = new System.Drawing.Point(368, 46);
            this.ButtonGrabar.Name = "ButtonGrabar";
            this.ButtonGrabar.Size = new System.Drawing.Size(171, 23);
            this.ButtonGrabar.TabIndex = 10;
            this.ButtonGrabar.Text = "Grabar";
            this.ButtonGrabar.UseVisualStyleBackColor = true;
            this.ButtonGrabar.Click += new System.EventHandler(this.ButtonGrabar_Click);
            // 
            // ButtonCancelar
            // 
            this.ButtonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonCancelar.Location = new System.Drawing.Point(368, 75);
            this.ButtonCancelar.Name = "ButtonCancelar";
            this.ButtonCancelar.Size = new System.Drawing.Size(171, 23);
            this.ButtonCancelar.TabIndex = 11;
            this.ButtonCancelar.Text = "Cancelar";
            this.ButtonCancelar.UseVisualStyleBackColor = true;
            // 
            // ButtonAnadirDiagnostico
            // 
            this.ButtonAnadirDiagnostico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonAnadirDiagnostico.Location = new System.Drawing.Point(429, 358);
            this.ButtonAnadirDiagnostico.Name = "ButtonAnadirDiagnostico";
            this.ButtonAnadirDiagnostico.Size = new System.Drawing.Size(128, 23);
            this.ButtonAnadirDiagnostico.TabIndex = 12;
            this.ButtonAnadirDiagnostico.Text = "Añadir Diagnostico";
            this.ButtonAnadirDiagnostico.UseVisualStyleBackColor = true;
            this.ButtonAnadirDiagnostico.Click += new System.EventHandler(this.ButtonAnadirDiagnostico_Click);
            // 
            // ButtonSalir
            // 
            this.ButtonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonSalir.Location = new System.Drawing.Point(429, 414);
            this.ButtonSalir.Name = "ButtonSalir";
            this.ButtonSalir.Size = new System.Drawing.Size(128, 23);
            this.ButtonSalir.TabIndex = 13;
            this.ButtonSalir.Text = "Salir";
            this.ButtonSalir.UseVisualStyleBackColor = true;
            this.ButtonSalir.Click += new System.EventHandler(this.ButtonSalir_Click);
            // 
            // LabelNombrePaciente
            // 
            this.LabelNombrePaciente.AutoSize = true;
            this.LabelNombrePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNombrePaciente.Location = new System.Drawing.Point(12, 6);
            this.LabelNombrePaciente.Name = "LabelNombrePaciente";
            this.LabelNombrePaciente.Size = new System.Drawing.Size(0, 30);
            this.LabelNombrePaciente.TabIndex = 14;
            // 
            // ButtonRetirarDiagnostico
            // 
            this.ButtonRetirarDiagnostico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonRetirarDiagnostico.Location = new System.Drawing.Point(429, 385);
            this.ButtonRetirarDiagnostico.Name = "ButtonRetirarDiagnostico";
            this.ButtonRetirarDiagnostico.Size = new System.Drawing.Size(128, 23);
            this.ButtonRetirarDiagnostico.TabIndex = 15;
            this.ButtonRetirarDiagnostico.Text = "Retirar Diagnostico";
            this.ButtonRetirarDiagnostico.UseVisualStyleBackColor = true;
            this.ButtonRetirarDiagnostico.Click += new System.EventHandler(this.ButtonRetirarDiagnostico_Click);
            // 
            // FormConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(569, 445);
            this.Controls.Add(this.ButtonRetirarDiagnostico);
            this.Controls.Add(this.LabelNombrePaciente);
            this.Controls.Add(this.ButtonSalir);
            this.Controls.Add(this.ButtonAnadirDiagnostico);
            this.Controls.Add(this.ButtonCancelar);
            this.Controls.Add(this.ButtonGrabar);
            this.Controls.Add(this.DataGridDiagnostico);
            this.Controls.Add(this.TextBoxTratamiento);
            this.Controls.Add(this.TextBoxDetalleAtencion);
            this.Controls.Add(this.TextBoxTiempoEnfermedad);
            this.Controls.Add(this.DateTimeFechaCita);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.FormConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDiagnostico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DateTimeFechaCita;
        private System.Windows.Forms.TextBox TextBoxTiempoEnfermedad;
        private System.Windows.Forms.TextBox TextBoxDetalleAtencion;
        private System.Windows.Forms.TextBox TextBoxTratamiento;
        private System.Windows.Forms.DataGridView DataGridDiagnostico;
        private System.Windows.Forms.Button ButtonGrabar;
        private System.Windows.Forms.Button ButtonCancelar;
        private System.Windows.Forms.Button ButtonAnadirDiagnostico;
        private System.Windows.Forms.Button ButtonSalir;
        private System.Windows.Forms.Label LabelNombrePaciente;
        private System.Windows.Forms.Button ButtonRetirarDiagnostico;
    }
}