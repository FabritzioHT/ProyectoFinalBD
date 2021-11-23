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
    public partial class FrmAddHotel : Form
    {
        ManejadorHotel mh;
        EntidadHotel eh;
        public FrmAddHotel()
        {
            mh = new ManejadorHotel();
            eh = new EntidadHotel();
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void Guardar()
        {

                eh._Nombre = txtNombre.Text;
                eh._Direccion = txtDir.Text;
                eh._Telefono = txtTel.Text;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guardar();
            if (FrmPrincipal.count == 1)
            {
                mh.Add(eh);
                this.Close();
            }
            else if (FrmPrincipal.count == 2)
            {
                mh.Upd(eh);
                this.Close();
            }
        }
    }
}
