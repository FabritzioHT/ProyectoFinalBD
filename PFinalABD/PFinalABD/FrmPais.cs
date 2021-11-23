using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejadores;
using Entidades;

namespace PFinalABD
{
    public partial class FrmPais : Form
    {
        ManejadorPais pa;
        EntidadPais ep;
        public FrmPais()
        {
            pa = new ManejadorPais();
            ep = new EntidadPais();
            InitializeComponent();
        }

        void Guardar()
        {

            ep._IDPais = int.Parse(txtID.Text);
            ep._Nombre = txtNombre.Text;
            ep._NClubes = int.Parse(txtNoClubes.Text);
            ep._FKIDPais = int.Parse(txtFKIDP.Text);


        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guardar();
            if (FrmPrincipal.count == 1)
            {
                pa.Add(ep);
                this.Close();
            }
            else if (FrmPrincipal.count == 2)
            {
                pa.Upd(ep);
                this.Close();
            }
        }
    }
}
