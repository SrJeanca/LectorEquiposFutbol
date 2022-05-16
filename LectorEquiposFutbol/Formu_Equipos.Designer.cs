namespace LectorEquiposFutbol
{
    partial class Formu_Equipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formu_Equipos));
            this.dataGVDatosEquipos = new System.Windows.Forms.DataGridView();
            this.btnDatos = new System.Windows.Forms.Button();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombreEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombreDirector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDatosEquipos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGVDatosEquipos
            // 
            this.dataGVDatosEquipos.AllowUserToAddRows = false;
            this.dataGVDatosEquipos.AllowUserToDeleteRows = false;
            this.dataGVDatosEquipos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(225)))));
            this.dataGVDatosEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVDatosEquipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.cNombreEquipo,
            this.cNombreDirector});
            this.dataGVDatosEquipos.Location = new System.Drawing.Point(49, 82);
            this.dataGVDatosEquipos.Name = "dataGVDatosEquipos";
            this.dataGVDatosEquipos.ReadOnly = true;
            this.dataGVDatosEquipos.Size = new System.Drawing.Size(478, 378);
            this.dataGVDatosEquipos.TabIndex = 4;
            // 
            // btnDatos
            // 
            this.btnDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(225)))));
            this.btnDatos.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnDatos.FlatAppearance.BorderSize = 2;
            this.btnDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatos.Location = new System.Drawing.Point(219, 29);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Size = new System.Drawing.Size(114, 31);
            this.btnDatos.TabIndex = 3;
            this.btnDatos.Text = "Traer Datos";
            this.btnDatos.UseVisualStyleBackColor = false;
            this.btnDatos.Click += new System.EventHandler(this.btnDatos_Click);
            // 
            // cId
            // 
            this.cId.DataPropertyName = "ID";
            this.cId.HeaderText = "ID";
            this.cId.Name = "cId";
            this.cId.ReadOnly = true;
            this.cId.Width = 50;
            // 
            // cNombreEquipo
            // 
            this.cNombreEquipo.DataPropertyName = "NombreEquipo";
            this.cNombreEquipo.HeaderText = "Nombre Equipo";
            this.cNombreEquipo.Name = "cNombreEquipo";
            this.cNombreEquipo.ReadOnly = true;
            this.cNombreEquipo.Width = 150;
            // 
            // cNombreDirector
            // 
            this.cNombreDirector.DataPropertyName = "NombreDirector";
            this.cNombreDirector.HeaderText = "Nombre Director";
            this.cNombreDirector.Name = "cNombreDirector";
            this.cNombreDirector.ReadOnly = true;
            this.cNombreDirector.Width = 200;
            // 
            // Formu_Equipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(570, 487);
            this.Controls.Add(this.dataGVDatosEquipos);
            this.Controls.Add(this.btnDatos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(494, 526);
            this.Name = "Formu_Equipos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDatosEquipos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGVDatosEquipos;
        private System.Windows.Forms.Button btnDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombreEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombreDirector;
    }
}