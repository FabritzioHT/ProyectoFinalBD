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
    public partial class FrmPartida : Form
    {
        ManejadorPartida par;
        EntidadPartida epar;
        public FrmPartida()
        {
            par = new ManejadorPartida();
            epar = new EntidadPartida();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Guardar()
        {
            epar._CodigoP = int.Parse(txtCod.Text);
            epar._Fecha = txtFecha.Text;
            epar._Jornada = txtJor.Text;
            epar._JugadorN = int.Parse(txtJN.Text);
            epar._JugadorB = int.Parse(txtJB.Text);
            epar._FKAlbitro = int.Parse(txtAl.Text);
            epar._FKSala = int.Parse(txtSa.Text);
            epar._Ganador = int.Parse(txtGa.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Guardar();
            if (FrmPrincipal.count == 1)
            {
                par.Add(epar);
                this.Close();
            }
            else if (FrmPrincipal.count == 2)
            {
                par.Upd(epar);
                this.Close();
            }
        }
    }
}
