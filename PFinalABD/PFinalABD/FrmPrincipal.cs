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
    public partial class FrmPrincipal : Form
    {
        ManejadorAlbitro ma;
        ManejadorHotel mh;
        ManejadorJugador mj;
        ManejadorMovimiento mm;
        ManejadorPais pa;
        ManejadorParticipantes paes;
        ManejadorPartida par;
        ManejadorRegistro mr;
        ManejadorSala ms;

        public static EntidadAlbitro ea;
        public static EntidadHotel eh;
        public static EntidadJugador ej;
        public static EntidadMovimiento em;
        public static EntidadPais ep;
        public static EntidadParticipantes epaes;
        public static EntidadPartida epar;
        public static EntidadRegistro er;
        public static EntidadSala es;
        
        public FrmPrincipal()
        {
            ma = new ManejadorAlbitro();
            mh = new ManejadorHotel();
            mj = new ManejadorJugador();
            mm = new ManejadorMovimiento();
            pa = new ManejadorPais();
            paes = new ManejadorParticipantes();
            par = new ManejadorPartida();
            mr = new ManejadorRegistro();
            ms = new ManejadorSala();

            ea = new EntidadAlbitro();
            eh = new EntidadHotel();
            ej = new EntidadJugador();
            em = new EntidadMovimiento();
            ep = new EntidadPais();
            epaes = new EntidadParticipantes();
            epar = new EntidadPartida();
            er = new EntidadRegistro();
            es = new EntidadSala();
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static Form frmactivo = null;
        public static Form frmhijo;
        public void AbrirFrmHijo(Form frmhijo)
        {

            if (frmactivo != null)
            {
                frmactivo.Close();
            }
            frmactivo = frmhijo;
            frmhijo.TopLevel = false;
            frmhijo.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(frmhijo);
            pnlContenedor.Tag = frmhijo;
            frmhijo.BringToFront();
            frmhijo.Show();
        }
        
        private void btnAlbitro_Click(object sender, EventArgs e)
        {
            lblTittle.Text = "ALBITRO";
            Actualizar();
        }

        private void btnHotel_Click(object sender, EventArgs e)
        {
            lblTittle.Text = "HOTEL";
            Actualizar();
        }

        private void btnJugador_Click(object sender, EventArgs e)
        {
            lblTittle.Text = "JUGADOR";
            Actualizar();
        }

        private void btnMovimiento_Click(object sender, EventArgs e)
        {
            lblTittle.Text = "MOVIMIENTO";
            Actualizar();
        }

        private void btnPais_Click(object sender, EventArgs e)
        {
            lblTittle.Text = "PAIS";
            Actualizar();
        }

        private void btnParticipante_Click(object sender, EventArgs e)
        {
            lblTittle.Text = "PARTICIPANTES";
            Actualizar();
        }

        private void btnPartida_Click(object sender, EventArgs e)
        {
            lblTittle.Text = "PARTIDA";
            Actualizar();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            lblTittle.Text = "REGISTRO";
            Actualizar();
        }

        private void btnSala_Click(object sender, EventArgs e)
        {
            count = 9;
            lblTittle.Text = "SALA";
            Actualizar();
        }

        void Actualizar()
        {
            if (lblTittle.Text == "ALBITRO")
            {
                ma.Show(dtgDatos, txtBuscar.Text);
            }
            if (lblTittle.Text == "HOTEL")
            {
                mh.Show(dtgDatos, txtBuscar.Text);
            }
            if (lblTittle.Text == "JUGADOR")
            {
                mj.Show(dtgDatos, txtBuscar.Text);
            }
            if (lblTittle.Text == "MOVIMIENTO")
            {
                mm.Show(dtgDatos, txtBuscar.Text);
            }
            if (lblTittle.Text == "PAIS")
            {
                pa.Show(dtgDatos, txtBuscar.Text);
            }
            if (lblTittle.Text == "PARTICIPANTES")
            {
                paes.Show(dtgDatos, txtBuscar.Text);
            }
            if (lblTittle.Text == "PARTIDA")
            {
                par.Show(dtgDatos, txtBuscar.Text);
            }
            if (lblTittle.Text == "REGISTRO")
            {
                mr.Show(dtgDatos, txtBuscar.Text);
            }
            if (lblTittle.Text == "SALA")
            {
                ms.Show(dtgDatos, txtBuscar.Text);
            }
        }
        void Delete()
        {
            if (lblTittle.Text == "ALBITRO")
            {
                ma.Del(ea);
            }
            else if (lblTittle.Text == "HOTEL")
            {
                    mh.Del(eh);
                    Actualizar();
            }
            else if (lblTittle.Text == "JUGADOR")
            {
                mj.Del(ej);
                }
            else if (lblTittle.Text == "MOVIMIENTO")
            {
                mm.Del(em);
                }
            else if (lblTittle.Text == "PAIS")
            {
                pa.Del(ep);
            }
            else if (lblTittle.Text == "PARTICIPANTES")
            {
                paes.Del(epaes);
            }
            else if (lblTittle.Text == "PARTIDA")
            {
                par.Del(epar);
            }
            else if (lblTittle.Text == "REGISTRO")
            {
                mr.Del(er);
            }
            else if (lblTittle.Text == "SALA")
            {
                ms.Del(es);
            }
            else
            {
                MessageBox.Show("No ha seleccionado ninguna tabla.");
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delete();
            Actualizar();
        }

        public static int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            count = 1;
            if (lblTittle.Text == "ALBITRO")
            {
                FrmAddAlbitro faa = new FrmAddAlbitro();
                faa.ShowDialog();
                Actualizar();
            }
            if (lblTittle.Text == "HOTEL")
            {
                FrmAddHotel fah = new FrmAddHotel();
                fah.ShowDialog();
                Actualizar();
            }
            if (lblTittle.Text == "JUGADOR")
            {
                FrmJugador fj = new FrmJugador();
                fj.ShowDialog();
                Actualizar();
            }
            if (lblTittle.Text == "MOVIMIENTO")
            {
                FrmMovimiento fm = new FrmMovimiento();
                fm.ShowDialog();
                Actualizar();
            }
            if (lblTittle.Text == "PAIS")
            {
                FrmPais fp = new FrmPais();
                fp.ShowDialog();
                Actualizar();
            }
            if (lblTittle.Text == "PARTICIPANTES")
            {
                FrmParticipantes fpa = new FrmParticipantes();
                fpa.ShowDialog();
                Actualizar();
            }
            if (lblTittle.Text == "PARTIDA")
            {
                FrmPartida fpar = new FrmPartida();
                fpar.ShowDialog();
                Actualizar();
            }
            if (lblTittle.Text == "REGISTRO")
            {
                FrmRegistro fr = new FrmRegistro();
                fr.ShowDialog();
                Actualizar();
            }
            if (lblTittle.Text == "SALA")
            {
                FrmSala fs = new FrmSala();
                fs.ShowDialog();
                Actualizar();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count = 2;
            if (lblTittle.Text == "ALBITRO")
            {
                FrmAddAlbitro faa = new FrmAddAlbitro();
                faa.ShowDialog();
            }
            else if (lblTittle.Text == "HOTEL")
            {
                FrmAddHotel fah = new FrmAddHotel();
                fah.ShowDialog();
            }
            else if (lblTittle.Text == "JUGADOR")
            {

            }
            else if (lblTittle.Text == "MOVIMIENTO")
            {

            }
            else if (lblTittle.Text == "PAIS")
            {
                FrmPais fp = new FrmPais();
                fp.Show();
            }
            else if (lblTittle.Text == "PARTICIPANTES")
            {

            }
            else if (lblTittle.Text == "PARTIDA")
            {

            }
            else if (lblTittle.Text == "REGISTRO")
            {

            }
            else if (lblTittle.Text == "SALA")
            {

            }
            
        }

        int i = 0;
        private void dtgDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (lblTittle.Text == "ALBITRO")
            {
                i = e.RowIndex;
                ea._IDAlbitro = int.Parse(dtgDatos.Rows[i].Cells[0].Value.ToString());
                ea._FKIDParticipante = int.Parse(dtgDatos.Rows[i].Cells[1].Value.ToString());
            }
            else if (lblTittle.Text == "HOTEL")
            {
                i = e.RowIndex;
                eh._Nombre = dtgDatos.Rows[i].Cells[0].Value.ToString();
                eh._Direccion = dtgDatos.Rows[i].Cells[1].Value.ToString();
                eh._Telefono = dtgDatos.Rows[i].Cells[2].Value.ToString();
            }
            else if (lblTittle.Text == "JUGADOR")
            {
                i = e.RowIndex;
                ej._IDJugador = int.Parse(dtgDatos.Rows[i].Cells[0].Value.ToString());
                ej._FKIDParticipante = int.Parse(dtgDatos.Rows[i].Cells[1].Value.ToString());
            }
            else if (lblTittle.Text == "MOVIMIENTO")
            {
                i = e.RowIndex;
                em._Movimiento = int.Parse(dtgDatos.Rows[i].Cells[0].Value.ToString());
                em._IDPartida = int.Parse(dtgDatos.Rows[i].Cells[1].Value.ToString());
                em._Jugada = dtgDatos.Rows[i].Cells[2].Value.ToString();
                em._Comentario = dtgDatos.Rows[i].Cells[3].Value.ToString();
                em._JugadorB = int.Parse(dtgDatos.Rows[i].Cells[4].Value.ToString());
                em._JugadorN = int.Parse(dtgDatos.Rows[i].Cells[5].Value.ToString());
                em._Fecha = dtgDatos.Rows[i].Cells[6].Value.ToString();
            }
            else if (lblTittle.Text == "PAIS")
            {
                i = e.RowIndex;
                ep._IDPais = int.Parse(dtgDatos.Rows[i].Cells[0].Value.ToString());
                ep._Nombre = dtgDatos.Rows[i].Cells[1].Value.ToString();
                ep._NClubes = int.Parse(dtgDatos.Rows[i].Cells[2].Value.ToString());
                ep._FKIDPais = int.Parse(dtgDatos.Rows[i].Cells[3].Value.ToString());
            }
            else if (lblTittle.Text == "PARTICIPANTES")
            {
                i = e.RowIndex;
                epaes._IDParticipante = int.Parse(dtgDatos.Rows[i].Cells[0].Value.ToString());
                epaes._Nombre = dtgDatos.Rows[i].Cells[1].Value.ToString();
                epaes._Direccion = dtgDatos.Rows[i].Cells[2].Value.ToString();
                epaes._Telefono = dtgDatos.Rows[i].Cells[3].Value.ToString();
                epaes._FKPais = int.Parse(dtgDatos.Rows[i].Cells[4].Value.ToString());
                epaes._Campeonato = dtgDatos.Rows[i].Cells[5].Value.ToString();
            }
            else if (lblTittle.Text == "PARTIDA")
            {
                epar._CodigoP = int.Parse(dtgDatos.Rows[i].Cells[0].Value.ToString());
                epar._Fecha = dtgDatos.Rows[i].Cells[1].Value.ToString();
                epar._Jornada = dtgDatos.Rows[i].Cells[2].Value.ToString();
                epar._JugadorN = int.Parse(dtgDatos.Rows[i].Cells[3].Value.ToString());
                epar._JugadorB = int.Parse(dtgDatos.Rows[i].Cells[4].Value.ToString());
                epar._FKAlbitro = int.Parse(dtgDatos.Rows[i].Cells[5].Value.ToString());
                epar._FKSala = int.Parse(dtgDatos.Rows[i].Cells[6].Value.ToString());
                epar._Ganador = int.Parse(dtgDatos.Rows[i].Cells[7].Value.ToString());
            }
            else if (lblTittle.Text == "REGISTRO")
            {
                er._IDAlojo = int.Parse(dtgDatos.Rows[i].Cells[0].Value.ToString());
                er._FEntrada = dtgDatos.Rows[i].Cells[1].Value.ToString();
                er._FSalida = dtgDatos.Rows[i].Cells[2].Value.ToString();
                er._FKParticipante = int.Parse(dtgDatos.Rows[i].Cells[3].Value.ToString());
                er._FKHotel = dtgDatos.Rows[i].Cells[4].Value.ToString();
            }
            else if (lblTittle.Text == "SALA")
            {
                es._IDSala = int.Parse(dtgDatos.Rows[i].Cells[0].Value.ToString());
                es._Codigo = dtgDatos.Rows[i].Cells[1].Value.ToString();
                es._Capacidad = dtgDatos.Rows[i].Cells[2].Value.ToString();
                es._Medio = dtgDatos.Rows[i].Cells[3].Value.ToString();
                es._FKHotel = dtgDatos.Rows[i].Cells[4].Value.ToString();
            }
        }
    }
}
