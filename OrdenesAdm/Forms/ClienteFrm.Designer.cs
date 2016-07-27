namespace OrdenesAdm.Forms
{
    partial class ClienteFrm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nombreTB = new System.Windows.Forms.TextBox();
            this.telefonoTB = new System.Windows.Forms.TextBox();
            this.ClientesDgv = new System.Windows.Forms.DataGridView();
            this.CancelarBT = new System.Windows.Forms.Button();
            this.EliminarBT = new System.Windows.Forms.Button();
            this.GuardarBT = new System.Windows.Forms.Button();
            this.ApellidoTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Teléfono";
            // 
            // nombreTB
            // 
            this.nombreTB.Location = new System.Drawing.Point(62, 12);
            this.nombreTB.Name = "nombreTB";
            this.nombreTB.Size = new System.Drawing.Size(230, 20);
            this.nombreTB.TabIndex = 4;
            // 
            // telefonoTB
            // 
            this.telefonoTB.Location = new System.Drawing.Point(62, 64);
            this.telefonoTB.Name = "telefonoTB";
            this.telefonoTB.Size = new System.Drawing.Size(125, 20);
            this.telefonoTB.TabIndex = 5;
            // 
            // ClientesDgv
            // 
            this.ClientesDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientesDgv.Location = new System.Drawing.Point(10, 123);
            this.ClientesDgv.Name = "ClientesDgv";
            this.ClientesDgv.Size = new System.Drawing.Size(449, 150);
            this.ClientesDgv.TabIndex = 8;
            this.ClientesDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientesDgv_CellClick);
            // 
            // CancelarBT
            // 
            this.CancelarBT.Location = new System.Drawing.Point(172, 94);
            this.CancelarBT.Name = "CancelarBT";
            this.CancelarBT.Size = new System.Drawing.Size(75, 23);
            this.CancelarBT.TabIndex = 11;
            this.CancelarBT.Text = "Cancelar";
            this.CancelarBT.UseVisualStyleBackColor = true;
            this.CancelarBT.Click += new System.EventHandler(this.CancelarBT_Click);
            // 
            // EliminarBT
            // 
            this.EliminarBT.Location = new System.Drawing.Point(91, 94);
            this.EliminarBT.Name = "EliminarBT";
            this.EliminarBT.Size = new System.Drawing.Size(75, 23);
            this.EliminarBT.TabIndex = 10;
            this.EliminarBT.Text = "Eliminar";
            this.EliminarBT.UseVisualStyleBackColor = true;
            this.EliminarBT.Click += new System.EventHandler(this.EliminarBT_Click);
            // 
            // GuardarBT
            // 
            this.GuardarBT.Location = new System.Drawing.Point(10, 94);
            this.GuardarBT.Name = "GuardarBT";
            this.GuardarBT.Size = new System.Drawing.Size(75, 23);
            this.GuardarBT.TabIndex = 9;
            this.GuardarBT.Text = "Guardar";
            this.GuardarBT.UseVisualStyleBackColor = true;
            this.GuardarBT.Click += new System.EventHandler(this.GuardarBT_Click);
            // 
            // ApellidoTB
            // 
            this.ApellidoTB.Location = new System.Drawing.Point(62, 38);
            this.ApellidoTB.Name = "ApellidoTB";
            this.ApellidoTB.Size = new System.Drawing.Size(230, 20);
            this.ApellidoTB.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Apellido";
            // 
            // ClienteFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 280);
            this.Controls.Add(this.ApellidoTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelarBT);
            this.Controls.Add(this.EliminarBT);
            this.Controls.Add(this.GuardarBT);
            this.Controls.Add(this.ClientesDgv);
            this.Controls.Add(this.telefonoTB);
            this.Controls.Add(this.nombreTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ClienteFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombreTB;
        private System.Windows.Forms.TextBox telefonoTB;
        private System.Windows.Forms.DataGridView ClientesDgv;
        private System.Windows.Forms.Button CancelarBT;
        private System.Windows.Forms.Button EliminarBT;
        private System.Windows.Forms.Button GuardarBT;
        private System.Windows.Forms.TextBox ApellidoTB;
        private System.Windows.Forms.Label label1;
    }
}