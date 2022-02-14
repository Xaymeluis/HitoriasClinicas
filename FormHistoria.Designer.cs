
namespace HistoriasClinicas
{
    partial class FormHistoria
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistoria));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBoxApellidoPaterno = new System.Windows.Forms.TextBox();
            this.TextBoxNombres = new System.Windows.Forms.TextBox();
            this.TextBoxDireccion = new System.Windows.Forms.TextBox();
            this.TextBoxTelefono = new System.Windows.Forms.TextBox();
            this.DateTimeFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.ButtonBuscarPaciente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxApellidoMaterno = new System.Windows.Forms.TextBox();
            this.ButtonAgregarConsulta = new System.Windows.Forms.Button();
            this.ButtonSalir = new System.Windows.Forms.Button();
            this.ButtonNuevo = new System.Windows.Forms.Button();
            this.ButtonGrabar = new System.Windows.Forms.Button();
            this.DataGridCitas = new System.Windows.Forms.DataGridView();
            this.LabelHistoria = new System.Windows.Forms.Label();
            this.ButtonEditar = new System.Windows.Forms.Button();
            this.ButtonCancelar = new System.Windows.Forms.Button();
            this.CheckMostrarConsultas = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCitas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historia Clínica #";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido Paterno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha de Nacimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dirección";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Teléfono";
            // 
            // TextBoxApellidoPaterno
            // 
            this.TextBoxApellidoPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxApellidoPaterno.Location = new System.Drawing.Point(127, 53);
            this.TextBoxApellidoPaterno.Name = "TextBoxApellidoPaterno";
            this.TextBoxApellidoPaterno.Size = new System.Drawing.Size(326, 20);
            this.TextBoxApellidoPaterno.TabIndex = 7;
            // 
            // TextBoxNombres
            // 
            this.TextBoxNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxNombres.Location = new System.Drawing.Point(127, 109);
            this.TextBoxNombres.Name = "TextBoxNombres";
            this.TextBoxNombres.Size = new System.Drawing.Size(326, 20);
            this.TextBoxNombres.TabIndex = 9;
            // 
            // TextBoxDireccion
            // 
            this.TextBoxDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxDireccion.Location = new System.Drawing.Point(127, 163);
            this.TextBoxDireccion.Name = "TextBoxDireccion";
            this.TextBoxDireccion.Size = new System.Drawing.Size(326, 20);
            this.TextBoxDireccion.TabIndex = 10;
            // 
            // TextBoxTelefono
            // 
            this.TextBoxTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxTelefono.Location = new System.Drawing.Point(127, 191);
            this.TextBoxTelefono.Name = "TextBoxTelefono";
            this.TextBoxTelefono.Size = new System.Drawing.Size(326, 20);
            this.TextBoxTelefono.TabIndex = 11;
            // 
            // DateTimeFechaNacimiento
            // 
            this.DateTimeFechaNacimiento.Location = new System.Drawing.Point(127, 137);
            this.DateTimeFechaNacimiento.Name = "DateTimeFechaNacimiento";
            this.DateTimeFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.DateTimeFechaNacimiento.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Consultas";
            // 
            // ButtonBuscarPaciente
            // 
            this.ButtonBuscarPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonBuscarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonBuscarPaciente.Location = new System.Drawing.Point(459, 52);
            this.ButtonBuscarPaciente.Name = "ButtonBuscarPaciente";
            this.ButtonBuscarPaciente.Size = new System.Drawing.Size(110, 23);
            this.ButtonBuscarPaciente.TabIndex = 15;
            this.ButtonBuscarPaciente.Text = "Buscar Paciente";
            this.ButtonBuscarPaciente.UseVisualStyleBackColor = true;
            this.ButtonBuscarPaciente.Click += new System.EventHandler(this.ButtonBuscarPaciente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido Materno";
            // 
            // TextBoxApellidoMaterno
            // 
            this.TextBoxApellidoMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxApellidoMaterno.Location = new System.Drawing.Point(128, 81);
            this.TextBoxApellidoMaterno.Name = "TextBoxApellidoMaterno";
            this.TextBoxApellidoMaterno.Size = new System.Drawing.Size(326, 20);
            this.TextBoxApellidoMaterno.TabIndex = 8;
            // 
            // ButtonAgregarConsulta
            // 
            this.ButtonAgregarConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAgregarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonAgregarConsulta.Location = new System.Drawing.Point(22, 294);
            this.ButtonAgregarConsulta.Name = "ButtonAgregarConsulta";
            this.ButtonAgregarConsulta.Size = new System.Drawing.Size(86, 114);
            this.ButtonAgregarConsulta.TabIndex = 16;
            this.ButtonAgregarConsulta.Text = "Agregar Consulta";
            this.ButtonAgregarConsulta.UseVisualStyleBackColor = true;
            this.ButtonAgregarConsulta.Click += new System.EventHandler(this.ButtonAgregarConsulta_Click);
            // 
            // ButtonSalir
            // 
            this.ButtonSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonSalir.Location = new System.Drawing.Point(420, 476);
            this.ButtonSalir.Name = "ButtonSalir";
            this.ButtonSalir.Size = new System.Drawing.Size(147, 27);
            this.ButtonSalir.TabIndex = 17;
            this.ButtonSalir.Text = "Salir";
            this.ButtonSalir.UseVisualStyleBackColor = true;
            this.ButtonSalir.Click += new System.EventHandler(this.ButtonSalir_Click);
            // 
            // ButtonNuevo
            // 
            this.ButtonNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonNuevo.Location = new System.Drawing.Point(256, 476);
            this.ButtonNuevo.Name = "ButtonNuevo";
            this.ButtonNuevo.Size = new System.Drawing.Size(147, 27);
            this.ButtonNuevo.TabIndex = 18;
            this.ButtonNuevo.Text = "Nuevo";
            this.ButtonNuevo.UseVisualStyleBackColor = true;
            this.ButtonNuevo.Click += new System.EventHandler(this.ButtonNuevo_Click);
            // 
            // ButtonGrabar
            // 
            this.ButtonGrabar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonGrabar.Location = new System.Drawing.Point(460, 80);
            this.ButtonGrabar.Name = "ButtonGrabar";
            this.ButtonGrabar.Size = new System.Drawing.Size(110, 23);
            this.ButtonGrabar.TabIndex = 20;
            this.ButtonGrabar.Text = "Grabar";
            this.ButtonGrabar.UseVisualStyleBackColor = true;
            this.ButtonGrabar.Click += new System.EventHandler(this.ButtonGrabar_Click);
            // 
            // DataGridCitas
            // 
            this.DataGridCitas.AllowUserToAddRows = false;
            this.DataGridCitas.AllowUserToDeleteRows = false;
            this.DataGridCitas.AllowUserToResizeColumns = false;
            this.DataGridCitas.AllowUserToResizeRows = false;
            this.DataGridCitas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridCitas.BackgroundColor = System.Drawing.Color.White;
            this.DataGridCitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridCitas.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridCitas.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridCitas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridCitas.Location = new System.Drawing.Point(128, 224);
            this.DataGridCitas.Name = "DataGridCitas";
            this.DataGridCitas.RowHeadersVisible = false;
            this.DataGridCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridCitas.Size = new System.Drawing.Size(438, 242);
            this.DataGridCitas.TabIndex = 21;
            this.DataGridCitas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridCitas_CellDoubleClick);
            // 
            // LabelHistoria
            // 
            this.LabelHistoria.AutoSize = true;
            this.LabelHistoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHistoria.Location = new System.Drawing.Point(246, 9);
            this.LabelHistoria.Name = "LabelHistoria";
            this.LabelHistoria.Size = new System.Drawing.Size(22, 30);
            this.LabelHistoria.TabIndex = 22;
            this.LabelHistoria.Text = "-";
            // 
            // ButtonEditar
            // 
            this.ButtonEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonEditar.Location = new System.Drawing.Point(460, 154);
            this.ButtonEditar.Name = "ButtonEditar";
            this.ButtonEditar.Size = new System.Drawing.Size(107, 25);
            this.ButtonEditar.TabIndex = 23;
            this.ButtonEditar.Text = "Editar";
            this.ButtonEditar.UseVisualStyleBackColor = true;
            this.ButtonEditar.Click += new System.EventHandler(this.ButtonEditar_Click);
            // 
            // ButtonCancelar
            // 
            this.ButtonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonCancelar.Location = new System.Drawing.Point(460, 185);
            this.ButtonCancelar.Name = "ButtonCancelar";
            this.ButtonCancelar.Size = new System.Drawing.Size(107, 25);
            this.ButtonCancelar.TabIndex = 24;
            this.ButtonCancelar.Text = "Cancelar";
            this.ButtonCancelar.UseVisualStyleBackColor = true;
            this.ButtonCancelar.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // CheckMostrarConsultas
            // 
            this.CheckMostrarConsultas.AutoSize = true;
            this.CheckMostrarConsultas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckMostrarConsultas.Location = new System.Drawing.Point(12, 255);
            this.CheckMostrarConsultas.Name = "CheckMostrarConsultas";
            this.CheckMostrarConsultas.Size = new System.Drawing.Size(87, 17);
            this.CheckMostrarConsultas.TabIndex = 25;
            this.CheckMostrarConsultas.Text = "Mostar todas";
            this.CheckMostrarConsultas.UseVisualStyleBackColor = true;
            this.CheckMostrarConsultas.Click += new System.EventHandler(this.CheckMostrarConsultas_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Location = new System.Drawing.Point(151, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 100);
            this.panel1.TabIndex = 27;
            this.panel1.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(17, 11);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(374, 55);
            this.progressBar1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(138, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Cargando Consultas ...";
            // 
            // FormHistoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(579, 517);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CheckMostrarConsultas);
            this.Controls.Add(this.ButtonCancelar);
            this.Controls.Add(this.ButtonEditar);
            this.Controls.Add(this.LabelHistoria);
            this.Controls.Add(this.DataGridCitas);
            this.Controls.Add(this.ButtonGrabar);
            this.Controls.Add(this.ButtonNuevo);
            this.Controls.Add(this.ButtonSalir);
            this.Controls.Add(this.ButtonAgregarConsulta);
            this.Controls.Add(this.ButtonBuscarPaciente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DateTimeFechaNacimiento);
            this.Controls.Add(this.TextBoxTelefono);
            this.Controls.Add(this.TextBoxDireccion);
            this.Controls.Add(this.TextBoxNombres);
            this.Controls.Add(this.TextBoxApellidoMaterno);
            this.Controls.Add(this.TextBoxApellidoPaterno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHistoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historia";
            this.Load += new System.EventHandler(this.FormHistoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCitas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextBoxApellidoPaterno;
        private System.Windows.Forms.TextBox TextBoxNombres;
        private System.Windows.Forms.TextBox TextBoxDireccion;
        private System.Windows.Forms.TextBox TextBoxTelefono;
        private System.Windows.Forms.DateTimePicker DateTimeFechaNacimiento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ButtonBuscarPaciente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxApellidoMaterno;
        private System.Windows.Forms.Button ButtonAgregarConsulta;
        private System.Windows.Forms.Button ButtonSalir;
        private System.Windows.Forms.Button ButtonNuevo;
        private System.Windows.Forms.Button ButtonGrabar;
        private System.Windows.Forms.DataGridView DataGridCitas;
        private System.Windows.Forms.Label LabelHistoria;
        private System.Windows.Forms.Button ButtonEditar;
        private System.Windows.Forms.Button ButtonCancelar;
        private System.Windows.Forms.CheckBox CheckMostrarConsultas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

