using OrdenesAdm.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenesAdm.Forms
{
    public partial class SuplidorFrm : Form
    {
        public SuplidorControlador controlador { get; set; }
        private int Id = 0;
        public SuplidorFrm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            this.nombreTB.MaxLength = 25;
            this.rncTB.MaxLength = 12;
            this.telefonoTB.MaxLength = 11;
            this.vmailTB.MaxLength = 60;
            Cargar();
        }

        private void Cargar()
        {
            suplidorDgv.DataSource = controlador.ObtenerTodos();
            suplidorDgv.Refresh();
        }

        private void Limpiar()
        {
            rncTB.Text = string.Empty;
            nombreTB.Text = string.Empty;
            telefonoTB.Text = string.Empty;
            vmailTB.Text = string.Empty;
            nombreTB.Focus();
        }

        private void suplidorDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            DataGridViewRow fila = suplidorDgv.Rows[e.RowIndex];
            this.Id = Convert.ToInt32(fila.Cells["SuplidorId"].Value);
            rncTB.Text = fila.Cells["RNC"].Value.ToString();
            nombreTB.Text = fila.Cells["Nombre"].Value.ToString();
            telefonoTB.Text = fila.Cells["Telefono"].Value.ToString();
            vmailTB.Text = fila.Cells["Vmail"].Value.ToString();
        }

        private void GuardarBT_Click(object sender, EventArgs e)
        {
            controlador.Guardar(rncTB.Text, nombreTB.Text, vmailTB.Text, telefonoTB.Text);
            Cargar();
            Limpiar();
        }

        private void EliminarBT_Click(object sender, EventArgs e)
        {
            controlador.Eliminar(Id);
            Cargar();
            Limpiar();
        }

        private void CancelarBT_Click(object sender, EventArgs e)
        {
            Id = 0;
            Limpiar();
        }

    }
}
