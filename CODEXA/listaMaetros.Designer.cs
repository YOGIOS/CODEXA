namespace CODEXA
{
    partial class listaMaetros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listaMaetros));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNombreDocente = new System.Windows.Forms.TextBox();
            this.txtCertificaciones = new System.Windows.Forms.TextBox();
            this.txtHorarioTrabajo = new System.Windows.Forms.TextBox();
            this.btnAñadirMst = new System.Windows.Forms.Button();
            this.btnEliminarMs = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.dvgFR = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgFR)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-216, -216);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1920, 1357);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(74, 64);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(176, 20);
            this.txtMatricula.TabIndex = 1;
            this.txtMatricula.Text = "Matricula";
            // 
            // txtNombreDocente
            // 
            this.txtNombreDocente.Location = new System.Drawing.Point(74, 90);
            this.txtNombreDocente.Name = "txtNombreDocente";
            this.txtNombreDocente.Size = new System.Drawing.Size(176, 20);
            this.txtNombreDocente.TabIndex = 2;
            this.txtNombreDocente.Text = "Nombre Docente";
            // 
            // txtCertificaciones
            // 
            this.txtCertificaciones.Location = new System.Drawing.Point(74, 116);
            this.txtCertificaciones.Name = "txtCertificaciones";
            this.txtCertificaciones.Size = new System.Drawing.Size(176, 20);
            this.txtCertificaciones.TabIndex = 3;
            this.txtCertificaciones.Text = "Certificacion";
            // 
            // txtHorarioTrabajo
            // 
            this.txtHorarioTrabajo.Location = new System.Drawing.Point(74, 142);
            this.txtHorarioTrabajo.Name = "txtHorarioTrabajo";
            this.txtHorarioTrabajo.Size = new System.Drawing.Size(176, 20);
            this.txtHorarioTrabajo.TabIndex = 4;
            this.txtHorarioTrabajo.Text = "Horario de trabajo";
            // 
            // btnAñadirMst
            // 
            this.btnAñadirMst.Location = new System.Drawing.Point(127, 217);
            this.btnAñadirMst.Name = "btnAñadirMst";
            this.btnAñadirMst.Size = new System.Drawing.Size(75, 23);
            this.btnAñadirMst.TabIndex = 6;
            this.btnAñadirMst.Text = "Añadir";
            this.btnAñadirMst.UseVisualStyleBackColor = true;
            this.btnAñadirMst.Click += new System.EventHandler(this.btnAñadirMst_Click);
            // 
            // btnEliminarMs
            // 
            this.btnEliminarMs.Location = new System.Drawing.Point(127, 246);
            this.btnEliminarMs.Name = "btnEliminarMs";
            this.btnEliminarMs.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarMs.TabIndex = 7;
            this.btnEliminarMs.Text = "Eliminar";
            this.btnEliminarMs.UseVisualStyleBackColor = true;
            this.btnEliminarMs.Click += new System.EventHandler(this.btnEliminarMs_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(127, 275);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Ayuda";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(127, 304);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(75, 23);
            this.btnReg.TabIndex = 9;
            this.btnReg.Text = "Regresar";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.button4_Click);
            // 
            // dvgFR
            // 
            this.dvgFR.AllowUserToOrderColumns = true;
            this.dvgFR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgFR.Location = new System.Drawing.Point(319, 51);
            this.dvgFR.Name = "dvgFR";
            this.dvgFR.Size = new System.Drawing.Size(593, 317);
            this.dvgFR.TabIndex = 10;
            this.dvgFR.DoubleClick += new System.EventHandler(this.dvgFR_DoubleClick);
            // 
            // listaMaetros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 510);
            this.Controls.Add(this.dvgFR);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnEliminarMs);
            this.Controls.Add(this.btnAñadirMst);
            this.Controls.Add(this.txtHorarioTrabajo);
            this.Controls.Add(this.txtCertificaciones);
            this.Controls.Add(this.txtNombreDocente);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.pictureBox1);
            this.Name = "listaMaetros";
            this.Text = "listaMaetros";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgFR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNombreDocente;
        private System.Windows.Forms.TextBox txtCertificaciones;
        private System.Windows.Forms.TextBox txtHorarioTrabajo;
        private System.Windows.Forms.Button btnAñadirMst;
        private System.Windows.Forms.Button btnEliminarMs;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.DataGridView dvgFR;
    }
}