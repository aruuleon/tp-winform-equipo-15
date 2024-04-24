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
    public partial class CategoriaAjustes : Form {
        public CategoriaAjustes() {
            InitializeComponent();
        }

        private void btnListaCategorias_Click(object sender, EventArgs e)
        {
            //VER QUE VENTANAS ESTAN BAIERTAS PARA LIMITAR EL NUMERO 
            foreach (var item in Application.OpenForms) //Application.OpenForms = lista de ventans abiertas
            {
                if (item.GetType() == typeof(ListaCategorias))
                {
                    MessageBox.Show("Ya existe una ventana abierta termine de trabajar alli...");
                    return;
                }
            }

            // -----------NAVEGAR A OTRA VENTANA--------------------------------
            ListaCategorias ventana = new ListaCategorias();

           

           ventana.Show(); //------------ ABRE SIEMPRE QUE APRETO EL BOTON UNA NUEVA VENTANA

            //ventana.ShowDialog(); 
        }
    }
}
