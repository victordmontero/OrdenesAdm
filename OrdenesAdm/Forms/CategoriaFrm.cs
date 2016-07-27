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
using OrdenesAdm.Controladores;

namespace OrdenesAdm.Forms
{
    public partial class CategoriaFrm : Form
    {

        private int Id = 0;

        public CategoriaControlador controlador { get; set; }
        public CategoriaFrm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            CargarDatos();
        }

        private void GuardarBT_Click(object sender, EventArgs e)
        {
            controlador.Guardar(this.DescripcionTB.Text);
            Limpiar();
            CargarDatos();

        }

        private void CargarDatos()
        {
            CategoriaDgv.DataSource = controlador.ObtenerTodos();
            CategoriaDgv.Refresh();
        }

        private void CategoriaDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            DataGridViewRow fila = CategoriaDgv.Rows[e.RowIndex];
            Id = Convert.ToInt32(fila.Cells[0].Value);
            DescripcionTB.Text = fila.Cells[1].Value.ToString();
            DescripcionTB.Focus();
        }

        private void EliminarBT_Click(object sender, EventArgs e)
        {
            controlador.Eliminar(this.Id);
        }

        private void CancelarBT_Click(object sender, EventArgs e)
        {
            Id = 0;
            Limpiar();
        }

        private void Limpiar()
        {
            DescripcionTB.Text = string.Empty;
        }



    }
}
