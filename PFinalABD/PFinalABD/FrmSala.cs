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
    public partial class FrmSala : Form
    {
        ManejadorSala ms;
        EntidadSala es;
        public FrmSala()
        {
            ms = new ManejadorSala();
            es = new EntidadSala();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Guardar()
        {
            es._IDSala = int.Parse(txtID.Text);
            es._Codigo = txtCodigo.Text;
            es._Capacidad = txtCap.Text;
            es._Medio = txtMedio.Text;
            es._FKHotel = txtFKH.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Guardar();
            if (FrmPrincipal.count == 1)
            {
                ms.Add(es);
                this.Close();
            }
            else if (FrmPrincipal.count == 2)
            {
                ms.Upd(es);
                this.Close();
            }
        }
    }
}
