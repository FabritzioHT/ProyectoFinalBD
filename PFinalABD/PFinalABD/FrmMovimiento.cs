using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Manejadores;

namespace PFinalABD
{
    public partial class FrmMovimiento : Form
    {
        ManejadorMovimiento mm;
        EntidadMovimiento em;
        public FrmMovimiento()
        {
            mm = new ManejadorMovimiento();
            em = new EntidadMovimiento();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Guardar()
        {
            em._Movimiento = int.Parse(txtID.Text);
            em._IDPartida = int.Parse(txtIDPartida.Text);
            em._Jugada = txtJugada.Text;
            em._Comentario = txtCom.Text;
            em._JugadorB = int.Parse(txtJB.Text);
            em._JugadorN = int.Parse(txtJN.Text);
            em._Fecha = txtFecha.Text;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Guardar();
            if (FrmPrincipal.count == 1)
            {
                mm.Add(em);
                this.Close();
            }
            else if (FrmPrincipal.count == 2)
            {
                mm.Upd(em);
                this.Close();
            }
        }
    }
}
