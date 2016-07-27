namespace OrdenesAdm.Forms
{
    partial class ProductoFrm
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
            this.nombreLB = new System.Windows.Forms.Label();
            this.precioLB = new System.Windows.Forms.Label();
            this.nombreTB = new System.Windows.Forms.TextBox();
            this.precioTB = new System.Windows.Forms.TextBox();
            this.CancelarBT = new System.Windows.Forms.Button();
            this.EliminarBT = new System.Windows.Forms.Button();
            this.GuardarBT = new System.Windows.Forms.Button();
            this.ProductoDgv = new System.Windows.Forms.DataGridView();
            this.CategoriaIdCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuplidorIdCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLB
            // 
            this.nombreLB.AutoSize = true;
            this.nombreLB.Location = new System.Drawing.Point(12, 9);
            this.nombreLB.Name = "nombreLB";
            this.nombreLB.Size = new System.Drawing.Size(44, 13);
            this.nombreLB.TabIndex = 0;
            this.nombreLB.Text = "Nombre";
            // 
            // precioLB
            // 
            this.precioLB.AutoSize = true;
            this.precioLB.Location = new System.Drawing.Point(12, 35);
            this.precioLB.Name = "precioLB";
            this.precioLB.Size = new System.Drawing.Size(37, 13);
            this.precioLB.TabIndex = 1;
            this.precioLB.Text = "Precio";
            // 
            // nombreTB
            // 
            this.nombreTB.Location = new System.Drawing.Point(60, 6);
            this.nombreTB.Name = "nombreTB";
            this.nombreTB.Size = new System.Drawing.Size(188, 20);
            this.nombreTB.TabIndex = 3;
            // 
            // precioTB
            // 
            this.precioTB.Location = new System.Drawing.Point(62, 32);
            this.precioTB.Name = "precioTB";
            this.precioTB.Size = new System.Drawing.Size(159, 20);
            this.precioTB.TabIndex = 4;
            // 
            // CancelarBT
            // 
            this.CancelarBT.Location = new System.Drawing.Point(176, 77);
            this.CancelarBT.Name = "CancelarBT";
            this.CancelarBT.Size = new System.Drawing.Size(75, 23);
            this.CancelarBT.TabIndex = 8;
            this.CancelarBT.Text = "Cancelar";
            this.CancelarBT.UseVisualStyleBackColor = true;
            this.CancelarBT.Click += new System.EventHandler(this.CancelarBT_Click);
            // 
            // EliminarBT
            // 
            this.EliminarBT.Location = new System.Drawing.Point(95, 77);
            this.EliminarBT.Name = "EliminarBT";
            this.EliminarBT.Size = new System.Drawing.Size(75, 23);
            this.EliminarBT.TabIndex = 7;
            this.EliminarBT.Text = "Eliminar";
            this.EliminarBT.UseVisualStyleBackColor = true;
            this.EliminarBT.Click += new System.EventHandler(this.EliminarBT_Click);
            // 
            // GuardarBT
            // 
            this.GuardarBT.Location = new System.Drawing.Point(14, 77);
            this.GuardarBT.Name = "GuardarBT";
            this.GuardarBT.Size = new System.Drawing.Size(75, 23);
            this.GuardarBT.TabIndex = 6;
            this.GuardarBT.Text = "Guardar";
            this.GuardarBT.UseVisualStyleBackColor = true;
            this.GuardarBT.Click += new System.EventHandler(this.GuardarBT_Click);
            // 
            // ProductoDgv
            // 
            this.ProductoDgv.AllowUserToAddRows = false;
            this.ProductoDgv.AllowUserToDeleteRows = false;
            this.ProductoDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductoDgv.Location = new System.Drawing.Point(15, 106);
            this.ProductoDgv.Name = "ProductoDgv";
            this.ProductoDgv.ReadOnly = true;
            this.ProductoDgv.Size = new System.Drawing.Size(622, 150);
            this.ProductoDgv.TabIndex = 9;
            this.ProductoDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductoDgv_CellClick);
            // 
            // CategoriaIdCB
            // 
            this.CategoriaIdCB.FormattingEnabled = true;
            this.CategoriaIdCB.Location = new System.Drawing.Point(320, 6);
            this.CategoriaIdCB.Name = "CategoriaIdCB";
            this.CategoriaIdCB.Size = new System.Drawing.Size(121, 21);
            this.CategoriaIdCB.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Categoría";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Suplidor";
            // 
            // SuplidorIdCB
            // 
            this.SuplidorIdCB.FormattingEnabled = true;
            this.SuplidorIdCB.Location = new System.Drawing.Point(320, 36);
            this.SuplidorIdCB.Name = "SuplidorIdCB";
            this.SuplidorIdCB.Size = new System.Drawing.Size(121, 21);
            this.SuplidorIdCB.TabIndex = 12;
            // 
            // ProductoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 267);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SuplidorIdCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CategoriaIdCB);
            this.Controls.Add(this.ProductoDgv);
            this.Controls.Add(this.CancelarBT);
            this.Controls.Add(this.EliminarBT);
            this.Controls.Add(this.GuardarBT);
            this.Controls.Add(this.precioTB);
            this.Controls.Add(this.nombreTB);
            this.Controls.Add(this.precioLB);
            this.Controls.Add(this.nombreLB);
            this.Name = "ProductoFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producto";
            ((System.ComponentModel.ISupportInitialize)(this.ProductoDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombreLB;
        private System.Windows.Forms.Label precioLB;
        private System.Windows.Forms.TextBox nombreTB;
        private System.Windows.Forms.TextBox precioTB;
        private System.Windows.Forms.Button CancelarBT;
        private System.Windows.Forms.Button EliminarBT;
        private System.Windows.Forms.Button GuardarBT;
        private System.Windows.Forms.DataGridView ProductoDgv;
        private System.Windows.Forms.ComboBox CategoriaIdCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SuplidorIdCB;
    }
}