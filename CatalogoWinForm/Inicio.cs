using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogoWinForm {
    public partial class Inicio : Form {
        public Inicio() {
            InitializeComponent();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            ListaCategorias ventana = new ListaCategorias();
            ventana.ShowDialog(); 
        }

        private void btnIncioMarcas_Click(object sender, EventArgs e)
        {
            ListaMarcas ventana = new ListaMarcas();            
            ventana.ShowDialog(); 
        }

        private void btnIncioArticulos_Click(object sender, EventArgs e)
        {          
            ListaArticulos ventana = new ListaArticulos();            
            ventana.ShowDialog(); 
        }
    }
}
