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
    public partial class FrmParticipantes : Form
    {
        ManejadorParticipantes paes;
        EntidadParticipantes epaes;
        public FrmParticipantes()
        {
            paes = new ManejadorParticipantes();
            epaes = new EntidadParticipantes();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void Guardar()
        {

            epaes._IDParticipante = int.Parse(txtID.Text);
            epaes._Nombre = txtNombre.Text;
            epaes._Direccion = txtDireccion.Text;
            epaes._Telefono = txtTel.Text;
            epaes._FKPais = int.Parse(txtFKIDP.Text);
            epaes._Campeonato = txtCamp.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guardar();
            if (FrmPrincipal.count == 1)
            {
                paes.Add(epaes);
                this.Close();
            }
            else if (FrmPrincipal.count == 2)
            {
                paes.Upd(epaes);
                this.Close();
            }
        }
    }
}
