namespace Parcial2_JuanElias
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignaturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscripcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignaturasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.estudiantesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignaturasToolStripMenuItem,
            this.estudiantesToolStripMenuItem,
            this.inscripcionesToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // asignaturasToolStripMenuItem
            // 
            this.asignaturasToolStripMenuItem.Name = "asignaturasToolStripMenuItem";
            this.asignaturasToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.asignaturasToolStripMenuItem.Text = "Asignaturas";
            this.asignaturasToolStripMenuItem.Click += new System.EventHandler(this.AsignaturasToolStripMenuItem_Click);
            // 
            // estudiantesToolStripMenuItem
            // 
            this.estudiantesToolStripMenuItem.Name = "estudiantesToolStripMenuItem";
            this.estudiantesToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.estudiantesToolStripMenuItem.Text = "Estudiantes";
            this.estudiantesToolStripMenuItem.Click += new System.EventHandler(this.EstudiantesToolStripMenuItem_Click);
            // 
            // inscripcionesToolStripMenuItem
            // 
            this.inscripcionesToolStripMenuItem.Name = "inscripcionesToolStripMenuItem";
            this.inscripcionesToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.inscripcionesToolStripMenuItem.Text = "Inscripciones";
            this.inscripcionesToolStripMenuItem.Click += new System.EventHandler(this.InscripcionesToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignaturasToolStripMenuItem1,
            this.estudiantesToolStripMenuItem1});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // asignaturasToolStripMenuItem1
            // 
            this.asignaturasToolStripMenuItem1.Name = "asignaturasToolStripMenuItem1";
            this.asignaturasToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.asignaturasToolStripMenuItem1.Text = "Asignaturas";
            this.asignaturasToolStripMenuItem1.Click += new System.EventHandler(this.AsignaturasToolStripMenuItem1_Click);
            // 
            // estudiantesToolStripMenuItem1
            // 
            this.estudiantesToolStripMenuItem1.Name = "estudiantesToolStripMenuItem1";
            this.estudiantesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.estudiantesToolStripMenuItem1.Text = "Estudiantes";
            this.estudiantesToolStripMenuItem1.Click += new System.EventHandler(this.EstudiantesToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Inicio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignaturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscripcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignaturasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem estudiantesToolStripMenuItem1;
    }
}

