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
    public partial class FrmJugador : Form
    {
        ManejadorJugador mj;
        EntidadJugador ej;
        public FrmJugador()
        {
            mj = new ManejadorJugador();
            ej = new EntidadJugador();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Guardar()
        {
            ej._IDJugador = int.Parse(txtID.Text);
            ej._FKIDParticipante = int.Parse(txtFKIDP.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Guardar();
            if (FrmPrincipal.count == 1)
            {
                mj.Add(ej);
                this.Close();
            }
            else if (FrmPrincipal.count == 2)
            {
                mj.Upd(ej);
                this.Close();
            }
        }
    }
}
