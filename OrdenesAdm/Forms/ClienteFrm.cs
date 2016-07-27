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
    public partial class ClienteFrm : Form
    {
        //private OrdenesAdmCL.BL.ClienteBL clienteBl;
        private int Id = 0;
        public ClienteFrm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            //this.nombreTB.MaxLength = 25;
            //this.ApellidoTB.MaxLength = 25;
            //this.telefonoTB.MaxLength = 11;
            //clienteBl = new OrdenesAdmCL.BL.ClienteBL();
            //Cargar();
        }

        private void Cargar()
        {
            //ClientesDgv.DataSource = clienteBl.CargarDatos();
            //ClientesDgv.Refresh();
        }

        private void ClientesDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex==-1)
            //    return;

            //DataGridViewRow fila = ClientesDgv.Rows[e.RowIndex];
            //Id = Convert.ToInt32(fila.Cells["Id"].Value);
            //nombreTB.Text = fila.Cells["Nombre"].Value.ToString();
            //ApellidoTB.Text = fila.Cells["Apellido"].Value.ToString();
            //telefonoTB.Text = (fila.Cells["Telefono"].Value == null ? "" : fila.Cells["Telefono"].Value.ToString());
            //nombreTB.Focus();
        }

        private void GuardarBT_Click(object sender, EventArgs e)
        {
            //OrdenesAdmCL.DB.Cliente cliente = new OrdenesAdmCL.DB.Cliente()
            //{
            //    Id=this.Id,
            //    Nombre = nombreTB.Text,
            //    Apellido = ApellidoTB.Text,
            //    Estado = true,
            //    Telefono = telefonoTB.Text,
            //    FechaCreacion = DateTime.Now
            //};
            //clienteBl.Agregar(cliente);
            //Cargar();
        }

        private void EliminarBT_Click(object sender, EventArgs e)
        {
            //if (this.Id == 0)
            //    return;

            //OrdenesAdmCL.DB.Cliente eliminando = new OrdenesAdmCL.DB.Cliente()
            //{
            //    Id = this.Id
            //};
            //clienteBl.Eliminar(eliminando);
            //Cargar();
            //Limpiar();
        }

        private void CancelarBT_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void Limpiar()
        {
            this.Id = 0;
            this.nombreTB.Text = string.Empty;
            this.ApellidoTB.Text = string.Empty;
            this.telefonoTB.Text = string.Empty;
            //this.nombreTB.Focus();
        }

    }
}
