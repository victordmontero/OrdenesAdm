namespace OrdenesAdm.Forms
{
    partial class CategoriaFrm
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
            this.DescripcionTB = new System.Windows.Forms.TextBox();
            this.DescripcionLB = new System.Windows.Forms.Label();
            this.CategoriaDgv = new System.Windows.Forms.DataGridView();
            this.GuardarBT = new System.Windows.Forms.Button();
            this.EliminarBT = new System.Windows.Forms.Button();
            this.CancelarBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriaDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // DescripcionTB
            // 
            this.DescripcionTB.Location = new System.Drawing.Point(94, 31);
            this.DescripcionTB.Name = "DescripcionTB";
            this.DescripcionTB.Size = new System.Drawing.Size(316, 20);
            this.DescripcionTB.TabIndex = 0;
            // 
            // DescripcionLB
            // 
            this.DescripcionLB.AutoSize = true;
            this.DescripcionLB.Location = new System.Drawing.Point(25, 38);
            this.DescripcionLB.Name = "DescripcionLB";
            this.DescripcionLB.Size = new System.Drawing.Size(63, 13);
            this.DescripcionLB.TabIndex = 1;
            this.DescripcionLB.Text = "Descripción";
            // 
            // CategoriaDgv
            // 
            this.CategoriaDgv.AllowUserToAddRows = false;
            this.CategoriaDgv.AllowUserToDeleteRows = false;
            this.CategoriaDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoriaDgv.Location = new System.Drawing.Point(12, 94);
            this.CategoriaDgv.MultiSelect = false;
            this.CategoriaDgv.Name = "CategoriaDgv";
            this.CategoriaDgv.ReadOnly = true;
            this.CategoriaDgv.Size = new System.Drawing.Size(446, 200);
            this.CategoriaDgv.TabIndex = 2;
            this.CategoriaDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoriaDgv_CellClick);
            // 
            // GuardarBT
            // 
            this.GuardarBT.Location = new System.Drawing.Point(94, 57);
            this.GuardarBT.Name = "GuardarBT";
            this.GuardarBT.Size = new System.Drawing.Size(75, 23);
            this.GuardarBT.TabIndex = 3;
            this.GuardarBT.Text = "Guardar";
            this.GuardarBT.UseVisualStyleBackColor = true;
            this.GuardarBT.Click += new System.EventHandler(this.GuardarBT_Click);
            // 
            // EliminarBT
            // 
            this.EliminarBT.Location = new System.Drawing.Point(175, 57);
            this.EliminarBT.Name = "EliminarBT";
            this.EliminarBT.Size = new System.Drawing.Size(75, 23);
            this.EliminarBT.TabIndex = 4;
            this.EliminarBT.Text = "Eliminar";
            this.EliminarBT.UseVisualStyleBackColor = true;
            this.EliminarBT.Click += new System.EventHandler(this.EliminarBT_Click);
            // 
            // CancelarBT
            // 
            this.CancelarBT.Location = new System.Drawing.Point(256, 57);
            this.CancelarBT.Name = "CancelarBT";
            this.CancelarBT.Size = new System.Drawing.Size(75, 23);
            this.CancelarBT.TabIndex = 5;
            this.CancelarBT.Text = "Cancelar";
            this.CancelarBT.UseVisualStyleBackColor = true;
            this.CancelarBT.Click += new System.EventHandler(this.CancelarBT_Click);
            // 
            // CategoriaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 306);
            this.Controls.Add(this.CancelarBT);
            this.Controls.Add(this.EliminarBT);
            this.Controls.Add(this.GuardarBT);
            this.Controls.Add(this.CategoriaDgv);
            this.Controls.Add(this.DescripcionLB);
            this.Controls.Add(this.DescripcionTB);
            this.Name = "CategoriaFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categoria";
            ((System.ComponentModel.ISupportInitialize)(this.CategoriaDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DescripcionTB;
        private System.Windows.Forms.Label DescripcionLB;
        private System.Windows.Forms.DataGridView CategoriaDgv;
        private System.Windows.Forms.Button GuardarBT;
        private System.Windows.Forms.Button EliminarBT;
        private System.Windows.Forms.Button CancelarBT;
    }
}