namespace CODEXA
{
    partial class listaAlumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listaAlumnos));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNumeroControl = new System.Windows.Forms.TextBox();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.txtSemestre = new System.Windows.Forms.TextBox();
            this.txtCondicionDiferente = new System.Windows.Forms.TextBox();
            this.txtAcreditacion = new System.Windows.Forms.TextBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dvgGrid = new System.Windows.Forms.DataGridView();
            this.btnRegre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-307, -206);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1920, 1357);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtNumeroControl
            // 
            this.txtNumeroControl.Location = new System.Drawing.Point(81, 31);
            this.txtNumeroControl.Name = "txtNumeroControl";
            this.txtNumeroControl.Size = new System.Drawing.Size(202, 20);
            this.txtNumeroControl.TabIndex = 1;
            this.txtNumeroControl.Text = "Numero De Control";
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(81, 57);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(202, 20);
            this.txtNombreAlumno.TabIndex = 2;
            this.txtNombreAlumno.Text = "Numero Del Alumno";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(81, 83);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(202, 20);
            this.txtEdad.TabIndex = 3;
            this.txtEdad.Text = "Edad";
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(81, 109);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(202, 20);
            this.txtGenero.TabIndex = 4;
            this.txtGenero.Text = "Genero";
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(81, 135);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(202, 20);
            this.txtCarrera.TabIndex = 5;
            this.txtCarrera.Text = "Carrera";
            // 
            // txtSemestre
            // 
            this.txtSemestre.Location = new System.Drawing.Point(81, 161);
            this.txtSemestre.Name = "txtSemestre";
            this.txtSemestre.Size = new System.Drawing.Size(202, 20);
            this.txtSemestre.TabIndex = 6;
            this.txtSemestre.Text = "Semestre";
            // 
            // txtCondicionDiferente
            // 
            this.txtCondicionDiferente.Location = new System.Drawing.Point(81, 187);
            this.txtCondicionDiferente.Name = "txtCondicionDiferente";
            this.txtCondicionDiferente.Size = new System.Drawing.Size(202, 20);
            this.txtCondicionDiferente.TabIndex = 7;
            this.txtCondicionDiferente.Text = "Condicion Diferente";
            // 
            // txtAcreditacion
            // 
            this.txtAcreditacion.Location = new System.Drawing.Point(81, 213);
            this.txtAcreditacion.Name = "txtAcreditacion";
            this.txtAcreditacion.Size = new System.Drawing.Size(202, 20);
            this.txtAcreditacion.TabIndex = 8;
            this.txtAcreditacion.Text = "Acreditacion";
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(142, 258);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(75, 23);
            this.btnAñadir.TabIndex = 9;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(142, 287);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(142, 316);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dvgGrid
            // 
            this.dvgGrid.AllowUserToOrderColumns = true;
            this.dvgGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgGrid.Location = new System.Drawing.Point(333, 31);
            this.dvgGrid.Name = "dvgGrid";
            this.dvgGrid.Size = new System.Drawing.Size(676, 385);
            this.dvgGrid.TabIndex = 12;
            this.dvgGrid.DoubleClick += new System.EventHandler(this.dvgGrid_DoubleClick);
            // 
            // btnRegre
            // 
            this.btnRegre.Location = new System.Drawing.Point(142, 345);
            this.btnRegre.Name = "btnRegre";
            this.btnRegre.Size = new System.Drawing.Size(75, 23);
            this.btnRegre.TabIndex = 13;
            this.btnRegre.Text = "Regresar";
            this.btnRegre.UseVisualStyleBackColor = true;
            this.btnRegre.Click += new System.EventHandler(this.btnRegre_Click);
            // 
            // listaAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 552);
            this.Controls.Add(this.btnRegre);
            this.Controls.Add(this.dvgGrid);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.txtAcreditacion);
            this.Controls.Add(this.txtCondicionDiferente);
            this.Controls.Add(this.txtSemestre);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombreAlumno);
            this.Controls.Add(this.txtNumeroControl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "listaAlumnos";
            this.Text = "listaAlumnos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNumeroControl;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.TextBox txtSemestre;
        private System.Windows.Forms.TextBox txtCondicionDiferente;
        private System.Windows.Forms.TextBox txtAcreditacion;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dvgGrid;
        private System.Windows.Forms.Button btnRegre;
    }
}