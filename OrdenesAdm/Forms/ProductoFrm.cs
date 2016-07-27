using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrdenesAdmCL;
using OrdenesAdmCL.Entities;
using OrdenesAdm.Controladores;

namespace OrdenesAdm.Forms
{
    public partial class ProductoFrm : Form
    {
        private int Id = 0;
        public ProductoControlador controlador { get; set; }
        public ProductoFrm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            this.nombreTB.MaxLength = 50;
            this.precioTB.MaxLength = 20;
            this.Cargar();
        }

        private void CargarCB()
        {
            CategoriaIdCB.DataSource = controlador.ObtenerCategorias();
            CategoriaIdCB.ValueMember = "CategoriaId";
            CategoriaIdCB.DisplayMember = "Descripcion";
            SuplidorIdCB.DataSource = controlador.ObtenerSuplidores();
            SuplidorIdCB.ValueMember = "SuplidorId";
            SuplidorIdCB.DisplayMember = "Nombre";

            ProductoDgv.DataSource = controlador.ObtenerTodos();
        }

        private void ProductoDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            DataGridViewRow fila = ProductoDgv.Rows[e.RowIndex];
            Id = Convert.ToInt32(fila.Cells["ProductoId"].Value);
            nombreTB.Text = fila.Cells["Nombre"].Value.ToString();
            precioTB.Text = fila.Cells["Precio"].Value.ToString();
            CategoriaIdCB.SelectedValue = Convert.ToInt32(fila.Cells["CategoriaId"].Value);
            SuplidorIdCB.SelectedValue = Convert.ToInt32(fila.Cells["SuplidorId"].Value);
        }

        private void Cargar()
        {
            CargarCB();

            ProductoDgv.Refresh();
        }

        private void Limpiar()
        {
            nombreTB.Text = string.Empty;
            precioTB.Text = string.Empty;
            nombreTB.Focus();
        }

        private void GuardarBT_Click(object sender, EventArgs e)
        {
            controlador.Guardar((int)CategoriaIdCB.SelectedValue,
                (int)SuplidorIdCB.SelectedValue, nombreTB.Text, Decimal.Parse(precioTB.Text));
            Cargar();
            Limpiar();
        }

        private void CancelarBT_Click(object sender, EventArgs e)
        {
            Id = 0;
            this.Limpiar();
        }

        private void EliminarBT_Click(object sender, EventArgs e)
        {
            controlador.Eliminar(this.Id);
            Cargar();
            Limpiar();
        }
    }
}
