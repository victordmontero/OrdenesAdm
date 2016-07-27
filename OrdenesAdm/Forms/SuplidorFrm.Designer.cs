namespace OrdenesAdm.Forms
{
    partial class SuplidorFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.rncTB = new System.Windows.Forms.TextBox();
            this.vmailTB = new System.Windows.Forms.TextBox();
            this.nombreTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.telefonoTB = new System.Windows.Forms.TextBox();
            this.CancelarBT = new System.Windows.Forms.Button();
            this.EliminarBT = new System.Windows.Forms.Button();
            this.GuardarBT = new System.Windows.Forms.Button();
            this.suplidorDgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.suplidorDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RNC";
            // 
            // rncTB
            // 
            this.rncTB.Location = new System.Drawing.Point(61, 6);
            this.rncTB.Name = "rncTB";
            this.rncTB.Size = new System.Drawing.Size(162, 20);
            this.rncTB.TabIndex = 1;
            // 
            // vmailTB
            // 
            this.vmailTB.Location = new System.Drawing.Point(61, 58);
            this.vmailTB.Name = "vmailTB";
            this.vmailTB.Size = new System.Drawing.Size(162, 20);
            this.vmailTB.TabIndex = 4;
            // 
            // nombreTB
            // 
            this.nombreTB.Location = new System.Drawing.Point(61, 32);
            this.nombreTB.Name = "nombreTB";
            this.nombreTB.Size = new System.Drawing.Size(162, 20);
            this.nombreTB.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vmail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nombre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(229, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Teléfono";
            // 
            // telefonoTB
            // 
            this.telefonoTB.Location = new System.Drawing.Point(289, 12);
            this.telefonoTB.Name = "telefonoTB";
            this.telefonoTB.Size = new System.Drawing.Size(162, 20);
            this.telefonoTB.TabIndex = 16;
            // 
            // CancelarBT
            // 
            this.CancelarBT.Location = new System.Drawing.Point(177, 84);
            this.CancelarBT.Name = "CancelarBT";
            this.CancelarBT.Size = new System.Drawing.Size(75, 23);
            this.CancelarBT.TabIndex = 20;
            this.CancelarBT.Text = "Cancelar";
            this.CancelarBT.UseVisualStyleBackColor = true;
            this.CancelarBT.Click += new System.EventHandler(this.CancelarBT_Click);
            // 
            // EliminarBT
            // 
            this.EliminarBT.Location = new System.Drawing.Point(96, 84);
            this.EliminarBT.Name = "EliminarBT";
            this.EliminarBT.Size = new System.Drawing.Size(75, 23);
            this.EliminarBT.TabIndex = 19;
            this.EliminarBT.Text = "Eliminar";
            this.EliminarBT.UseVisualStyleBackColor = true;
            this.EliminarBT.Click += new System.EventHandler(this.EliminarBT_Click);
            // 
            // GuardarBT
            // 
            this.GuardarBT.Location = new System.Drawing.Point(15, 84);
            this.GuardarBT.Name = "GuardarBT";
            this.GuardarBT.Size = new System.Drawing.Size(75, 23);
            this.GuardarBT.TabIndex = 18;
            this.GuardarBT.Text = "Guardar";
            this.GuardarBT.UseVisualStyleBackColor = true;
            this.GuardarBT.Click += new System.EventHandler(this.GuardarBT_Click);
            // 
            // suplidorDgv
            // 
            this.suplidorDgv.AllowUserToAddRows = false;
            this.suplidorDgv.AllowUserToDeleteRows = false;
            this.suplidorDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suplidorDgv.Location = new System.Drawing.Point(10, 113);
            this.suplidorDgv.Name = "suplidorDgv";
            this.suplidorDgv.ReadOnly = true;
            this.suplidorDgv.Size = new System.Drawing.Size(743, 213);
            this.suplidorDgv.TabIndex = 21;
            this.suplidorDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.suplidorDgv_CellClick);
            // 
            // SuplidorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 336);
            this.Controls.Add(this.suplidorDgv);
            this.Controls.Add(this.CancelarBT);
            this.Controls.Add(this.EliminarBT);
            this.Controls.Add(this.GuardarBT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.telefonoTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nombreTB);
            this.Controls.Add(this.vmailTB);
            this.Controls.Add(this.rncTB);
            this.Controls.Add(this.label1);
            this.Name = "SuplidorFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suplidor";
            ((System.ComponentModel.ISupportInitialize)(this.suplidorDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rncTB;
        private System.Windows.Forms.TextBox vmailTB;
        private System.Windows.Forms.TextBox nombreTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox telefonoTB;
        private System.Windows.Forms.Button CancelarBT;
        private System.Windows.Forms.Button EliminarBT;
        private System.Windows.Forms.Button GuardarBT;
        private System.Windows.Forms.DataGridView suplidorDgv;
    }
}