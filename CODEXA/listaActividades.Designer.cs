namespace CODEXA
{
    partial class listaActividades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listaActividades));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtIDACT = new System.Windows.Forms.TextBox();
            this.txtNombreACT = new System.Windows.Forms.TextBox();
            this.txtDocenteACT = new System.Windows.Forms.TextBox();
            this.txtGrupoACT = new System.Windows.Forms.TextBox();
            this.dgvGrid = new System.Windows.Forms.DataGridView();
            this.btnAñadr = new System.Windows.Forms.Button();
            this.btnElimn = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnRegr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-160, -238);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1920, 1357);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtIDACT
            // 
            this.txtIDACT.Location = new System.Drawing.Point(125, 46);
            this.txtIDACT.Name = "txtIDACT";
            this.txtIDACT.Size = new System.Drawing.Size(188, 20);
            this.txtIDACT.TabIndex = 1;
            this.txtIDACT.Text = "ID Actividad";
            // 
            // txtNombreACT
            // 
            this.txtNombreACT.Location = new System.Drawing.Point(125, 72);
            this.txtNombreACT.Name = "txtNombreACT";
            this.txtNombreACT.Size = new System.Drawing.Size(188, 20);
            this.txtNombreACT.TabIndex = 2;
            this.txtNombreACT.Text = "Nombre de la Actividad";
            // 
            // txtDocenteACT
            // 
            this.txtDocenteACT.Location = new System.Drawing.Point(125, 98);
            this.txtDocenteACT.Name = "txtDocenteACT";
            this.txtDocenteACT.Size = new System.Drawing.Size(188, 20);
            this.txtDocenteACT.TabIndex = 3;
            this.txtDocenteACT.Text = "Docente";
            // 
            // txtGrupoACT
            // 
            this.txtGrupoACT.Location = new System.Drawing.Point(125, 124);
            this.txtGrupoACT.Name = "txtGrupoACT";
            this.txtGrupoACT.Size = new System.Drawing.Size(188, 20);
            this.txtGrupoACT.TabIndex = 4;
            this.txtGrupoACT.Text = "Grupos";
            // 
            // dgvGrid
            // 
            this.dgvGrid.AllowUserToOrderColumns = true;
            this.dgvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrid.Location = new System.Drawing.Point(336, 28);
            this.dgvGrid.Name = "dgvGrid";
            this.dgvGrid.Size = new System.Drawing.Size(709, 385);
            this.dgvGrid.TabIndex = 5;
            this.dgvGrid.DoubleClick += new System.EventHandler(this.dgvGrid_DoubleClick);
            // 
            // btnAñadr
            // 
            this.btnAñadr.Location = new System.Drawing.Point(172, 184);
            this.btnAñadr.Name = "btnAñadr";
            this.btnAñadr.Size = new System.Drawing.Size(90, 41);
            this.btnAñadr.TabIndex = 6;
            this.btnAñadr.Text = "Añadir";
            this.btnAñadr.UseVisualStyleBackColor = true;
            this.btnAñadr.Click += new System.EventHandler(this.btnAñadr_Click);
            // 
            // btnElimn
            // 
            this.btnElimn.Location = new System.Drawing.Point(172, 231);
            this.btnElimn.Name = "btnElimn";
            this.btnElimn.Size = new System.Drawing.Size(90, 41);
            this.btnElimn.TabIndex = 7;
            this.btnElimn.Text = "Eliminar";
            this.btnElimn.UseVisualStyleBackColor = true;
            this.btnElimn.Click += new System.EventHandler(this.btnElimn_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Location = new System.Drawing.Point(172, 278);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(90, 41);
            this.btnAyuda.TabIndex = 8;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnRegr
            // 
            this.btnRegr.Location = new System.Drawing.Point(172, 325);
            this.btnRegr.Name = "btnRegr";
            this.btnRegr.Size = new System.Drawing.Size(90, 41);
            this.btnRegr.TabIndex = 9;
            this.btnRegr.Text = "Regresar";
            this.btnRegr.UseVisualStyleBackColor = true;
            this.btnRegr.Click += new System.EventHandler(this.btnRegr_Click);
            // 
            // listaActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 530);
            this.Controls.Add(this.btnRegr);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnElimn);
            this.Controls.Add(this.btnAñadr);
            this.Controls.Add(this.dgvGrid);
            this.Controls.Add(this.txtGrupoACT);
            this.Controls.Add(this.txtDocenteACT);
            this.Controls.Add(this.txtNombreACT);
            this.Controls.Add(this.txtIDACT);
            this.Controls.Add(this.pictureBox1);
            this.Name = "listaActividades";
            this.Text = "listaActividades";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtIDACT;
        private System.Windows.Forms.TextBox txtNombreACT;
        private System.Windows.Forms.TextBox txtDocenteACT;
        private System.Windows.Forms.TextBox txtGrupoACT;
        private System.Windows.Forms.DataGridView dgvGrid;
        private System.Windows.Forms.Button btnAñadr;
        private System.Windows.Forms.Button btnElimn;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnRegr;
    }
}