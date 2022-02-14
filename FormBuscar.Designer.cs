
namespace HistoriasClinicas
{
    partial class FormBuscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscar));
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxBuscar = new System.Windows.Forms.TextBox();
            this.DataGridResultado = new System.Windows.Forms.DataGridView();
            this.ButtonSalir = new System.Windows.Forms.Button();
            this.ButtonAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            // 
            // TextBoxBuscar
            // 
            this.TextBoxBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxBuscar.Location = new System.Drawing.Point(12, 26);
            this.TextBoxBuscar.Name = "TextBoxBuscar";
            this.TextBoxBuscar.Size = new System.Drawing.Size(441, 20);
            this.TextBoxBuscar.TabIndex = 1;
            this.TextBoxBuscar.TextChanged += new System.EventHandler(this.TextBoxBuscar_TextChanged);
            // 
            // DataGridResultado
            // 
            this.DataGridResultado.AllowUserToAddRows = false;
            this.DataGridResultado.AllowUserToDeleteRows = false;
            this.DataGridResultado.AllowUserToOrderColumns = true;
            this.DataGridResultado.AllowUserToResizeColumns = false;
            this.DataGridResultado.BackgroundColor = System.Drawing.Color.White;
            this.DataGridResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridResultado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridResultado.GridColor = System.Drawing.Color.Black;
            this.DataGridResultado.Location = new System.Drawing.Point(12, 52);
            this.DataGridResultado.Name = "DataGridResultado";
            this.DataGridResultado.RowHeadersVisible = false;
            this.DataGridResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridResultado.Size = new System.Drawing.Size(441, 241);
            this.DataGridResultado.TabIndex = 2;
            this.DataGridResultado.DoubleClick += new System.EventHandler(this.DataGridResultado_DoubleClick);
            // 
            // ButtonSalir
            // 
            this.ButtonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonSalir.Location = new System.Drawing.Point(327, 299);
            this.ButtonSalir.Name = "ButtonSalir";
            this.ButtonSalir.Size = new System.Drawing.Size(126, 23);
            this.ButtonSalir.TabIndex = 3;
            this.ButtonSalir.Text = "Salir";
            this.ButtonSalir.UseVisualStyleBackColor = true;
            this.ButtonSalir.Click += new System.EventHandler(this.ButtonSalir_Click);
            // 
            // ButtonAceptar
            // 
            this.ButtonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonAceptar.Location = new System.Drawing.Point(195, 299);
            this.ButtonAceptar.Name = "ButtonAceptar";
            this.ButtonAceptar.Size = new System.Drawing.Size(126, 23);
            this.ButtonAceptar.TabIndex = 4;
            this.ButtonAceptar.Text = "Aceptar";
            this.ButtonAceptar.UseVisualStyleBackColor = true;
            this.ButtonAceptar.Click += new System.EventHandler(this.ButtonAceptar_Click);
            // 
            // FormBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(463, 327);
            this.Controls.Add(this.ButtonAceptar);
            this.Controls.Add(this.ButtonSalir);
            this.Controls.Add(this.DataGridResultado);
            this.Controls.Add(this.TextBoxBuscar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBuscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buscar";
            this.Load += new System.EventHandler(this.FormBuscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxBuscar;
        private System.Windows.Forms.DataGridView DataGridResultado;
        private System.Windows.Forms.Button ButtonSalir;
        private System.Windows.Forms.Button ButtonAceptar;
    }
}