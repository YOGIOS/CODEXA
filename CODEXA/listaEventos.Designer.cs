namespace CODEXA
{
    partial class listaEventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listaEventos));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtIDeve = new System.Windows.Forms.TextBox();
            this.txtNombreEve = new System.Windows.Forms.TextBox();
            this.txttipoEve = new System.Windows.Forms.TextBox();
            this.txtFechaEve = new System.Windows.Forms.TextBox();
            this.txtLugarEve = new System.Windows.Forms.TextBox();
            this.btnAñadirEve = new System.Windows.Forms.Button();
            this.btnEliminarEve = new System.Windows.Forms.Button();
            this.btnAyda = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-144, -221);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1920, 1357);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtIDeve
            // 
            this.txtIDeve.Location = new System.Drawing.Point(96, 37);
            this.txtIDeve.Name = "txtIDeve";
            this.txtIDeve.Size = new System.Drawing.Size(196, 20);
            this.txtIDeve.TabIndex = 1;
            this.txtIDeve.Text = "ID evento";
            // 
            // txtNombreEve
            // 
            this.txtNombreEve.Location = new System.Drawing.Point(96, 63);
            this.txtNombreEve.Name = "txtNombreEve";
            this.txtNombreEve.Size = new System.Drawing.Size(196, 20);
            this.txtNombreEve.TabIndex = 2;
            this.txtNombreEve.Text = "Nombre Evento";
            // 
            // txttipoEve
            // 
            this.txttipoEve.Location = new System.Drawing.Point(96, 89);
            this.txttipoEve.Name = "txttipoEve";
            this.txttipoEve.Size = new System.Drawing.Size(196, 20);
            this.txttipoEve.TabIndex = 3;
            this.txttipoEve.Text = "Tipo Evento";
            // 
            // txtFechaEve
            // 
            this.txtFechaEve.Location = new System.Drawing.Point(96, 115);
            this.txtFechaEve.Name = "txtFechaEve";
            this.txtFechaEve.Size = new System.Drawing.Size(196, 20);
            this.txtFechaEve.TabIndex = 4;
            this.txtFechaEve.Text = "Fecha Evento";
            // 
            // txtLugarEve
            // 
            this.txtLugarEve.Location = new System.Drawing.Point(96, 141);
            this.txtLugarEve.Name = "txtLugarEve";
            this.txtLugarEve.Size = new System.Drawing.Size(196, 20);
            this.txtLugarEve.TabIndex = 5;
            this.txtLugarEve.Text = "Lugar Objeto";
            // 
            // btnAñadirEve
            // 
            this.btnAñadirEve.Location = new System.Drawing.Point(154, 167);
            this.btnAñadirEve.Name = "btnAñadirEve";
            this.btnAñadirEve.Size = new System.Drawing.Size(118, 66);
            this.btnAñadirEve.TabIndex = 6;
            this.btnAñadirEve.Text = "Añadir";
            this.btnAñadirEve.UseVisualStyleBackColor = true;
            this.btnAñadirEve.Click += new System.EventHandler(this.btnAñadirEve_Click);
            // 
            // btnEliminarEve
            // 
            this.btnEliminarEve.Location = new System.Drawing.Point(154, 239);
            this.btnEliminarEve.Name = "btnEliminarEve";
            this.btnEliminarEve.Size = new System.Drawing.Size(118, 68);
            this.btnEliminarEve.TabIndex = 7;
            this.btnEliminarEve.Text = "Eliminar";
            this.btnEliminarEve.UseVisualStyleBackColor = true;
            this.btnEliminarEve.Click += new System.EventHandler(this.btnEliminarEve_Click);
            // 
            // btnAyda
            // 
            this.btnAyda.Location = new System.Drawing.Point(154, 313);
            this.btnAyda.Name = "btnAyda";
            this.btnAyda.Size = new System.Drawing.Size(118, 59);
            this.btnAyda.TabIndex = 8;
            this.btnAyda.Text = "Ayudar";
            this.btnAyda.UseVisualStyleBackColor = true;
            this.btnAyda.Click += new System.EventHandler(this.btnAyda_Click);
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(154, 378);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(118, 65);
            this.btnR.TabIndex = 9;
            this.btnR.Text = "Regresar";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(346, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(635, 302);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // listaEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 541);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnAyda);
            this.Controls.Add(this.btnEliminarEve);
            this.Controls.Add(this.btnAñadirEve);
            this.Controls.Add(this.txtLugarEve);
            this.Controls.Add(this.txtFechaEve);
            this.Controls.Add(this.txttipoEve);
            this.Controls.Add(this.txtNombreEve);
            this.Controls.Add(this.txtIDeve);
            this.Controls.Add(this.pictureBox1);
            this.Name = "listaEventos";
            this.Text = "listaEventos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtIDeve;
        private System.Windows.Forms.TextBox txtNombreEve;
        private System.Windows.Forms.TextBox txttipoEve;
        private System.Windows.Forms.TextBox txtFechaEve;
        private System.Windows.Forms.TextBox txtLugarEve;
        private System.Windows.Forms.Button btnAñadirEve;
        private System.Windows.Forms.Button btnEliminarEve;
        private System.Windows.Forms.Button btnAyda;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}