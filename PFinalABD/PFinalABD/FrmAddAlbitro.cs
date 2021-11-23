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
    public partial class FrmAddAlbitro : Form
    {
        ManejadorAlbitro ma;

        public static EntidadAlbitro ea;
        public FrmAddAlbitro()
        {
            ma = new ManejadorAlbitro();

            ea = new EntidadAlbitro();
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void Guardar()
        {
                ea._IDAlbitro = int.Parse(txtID.Text);
                ea._FKIDParticipante = int.Parse(txtFKIDP.Text);
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Guardar();
            if (FrmPrincipal.count == 1)
            {
                ma.Add(ea);
                this.Close();
            }
            else if(FrmPrincipal.count == 2)
            {
                ma.Upd(ea);
                this.Close();
            }
        }
    }
}
