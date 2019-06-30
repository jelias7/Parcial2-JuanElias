namespace Parcial2_JuanElias.UI.Registros
{
    partial class rEstudiantes
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EstudianteIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BalancenumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NombrestextBox = new System.Windows.Forms.TextBox();
            this.FechaIngresodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EstudianteIdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BalancenumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "EstudianteId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Ingreso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Balance";
            // 
            // EstudianteIdnumericUpDown
            // 
            this.EstudianteIdnumericUpDown.Location = new System.Drawing.Point(117, 18);
            this.EstudianteIdnumericUpDown.Name = "EstudianteIdnumericUpDown";
            this.EstudianteIdnumericUpDown.Size = new System.Drawing.Size(56, 20);
            this.EstudianteIdnumericUpDown.TabIndex = 4;
            // 
            // BalancenumericUpDown
            // 
            this.BalancenumericUpDown.DecimalPlaces = 2;
            this.BalancenumericUpDown.Location = new System.Drawing.Point(117, 141);
            this.BalancenumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.BalancenumericUpDown.Name = "BalancenumericUpDown";
            this.BalancenumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.BalancenumericUpDown.TabIndex = 5;
            // 
            // NombrestextBox
            // 
            this.NombrestextBox.Location = new System.Drawing.Point(117, 103);
            this.NombrestextBox.Name = "NombrestextBox";
            this.NombrestextBox.Size = new System.Drawing.Size(283, 20);
            this.NombrestextBox.TabIndex = 6;
            this.NombrestextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombrestextBox_KeyPress);
            // 
            // FechaIngresodateTimePicker
            // 
            this.FechaIngresodateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaIngresodateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaIngresodateTimePicker.Location = new System.Drawing.Point(117, 63);
            this.FechaIngresodateTimePicker.Name = "FechaIngresodateTimePicker";
            this.FechaIngresodateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.FechaIngresodateTimePicker.TabIndex = 7;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::Parcial2_JuanElias.Properties.Resources.check_ok_accept_apply_1582;
            this.Guardarbutton.Location = new System.Drawing.Point(162, 178);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 49);
            this.Guardarbutton.TabIndex = 9;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::Parcial2_JuanElias.Properties.Resources.delete_delete_exit_1577;
            this.Eliminarbutton.Location = new System.Drawing.Point(297, 178);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 49);
            this.Eliminarbutton.TabIndex = 10;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::Parcial2_JuanElias.Properties.Resources.Search_find_locate_1542;
            this.Buscarbutton.Location = new System.Drawing.Point(189, 7);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(48, 39);
            this.Buscarbutton.TabIndex = 11;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::Parcial2_JuanElias.Properties.Resources.add_insert_plus_1588;
            this.Nuevobutton.Location = new System.Drawing.Point(27, 178);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 49);
            this.Nuevobutton.TabIndex = 8;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // rEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 239);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.FechaIngresodateTimePicker);
            this.Controls.Add(this.NombrestextBox);
            this.Controls.Add(this.BalancenumericUpDown);
            this.Controls.Add(this.EstudianteIdnumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "rEstudiantes";
            this.Text = "Registro de Estudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.EstudianteIdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BalancenumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown EstudianteIdnumericUpDown;
        private System.Windows.Forms.NumericUpDown BalancenumericUpDown;
        private System.Windows.Forms.TextBox NombrestextBox;
        private System.Windows.Forms.DateTimePicker FechaIngresodateTimePicker;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}