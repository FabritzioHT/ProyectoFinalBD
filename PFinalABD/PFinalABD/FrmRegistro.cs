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
    public partial class FrmRegistro : Form
    {
        ManejadorRegistro mr;
        EntidadRegistro er;
        public FrmRegistro()
        {
            mr = new ManejadorRegistro();
            er = new EntidadRegistro();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         void Guardar()
        {
            er._IDAlojo = int.Parse(txtID.Text);
            er._FEntrada = txtEntrada.Text;
            er._FSalida = txtSalida.Text;
            er._FKParticipante = int.Parse(txtFKIDPa.Text);
            er._FKHotel = txtFKH.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Guardar();
            if (FrmPrincipal.count == 1)
            {
                mr.Add(er);
                this.Close();
            }
            else if (FrmPrincipal.count == 2)
            {
                mr.Upd(er);
                this.Close();
            }
        }
    }
}
