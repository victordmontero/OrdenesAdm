using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrdenesAdm.Forms;
using OrdenesAdm.Controladores;

namespace OrdenesAdm
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void categoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var categoriaView = new CategoriaFrm();
            //--------------------------------------
            var categoriaController = new CategoriaControlador();

            categoriaView.controlador = categoriaController;
            categoriaController.CategoriaVista = categoriaView;

            categoriaView.MdiParent = this;
            categoriaView.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var productoVista = new ProductoFrm();
            var productoControlador = new ProductoControlador();

            productoVista.controlador = productoControlador;
            productoControlador.ProductoVista = productoVista;

            productoVista.MdiParent = this;
            productoVista.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdenesAdm.Forms.ClienteFrm Cl = new ClienteFrm();
            Cl.MdiParent = this;
            Cl.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var suplidorVista = new SuplidorFrm();
            var suplidorControlador = new SuplidorControlador();

            suplidorVista.controlador = suplidorControlador;
            suplidorControlador.SuplidorVista = suplidorVista;
            suplidorVista.MdiParent = this;
            suplidorVista.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
