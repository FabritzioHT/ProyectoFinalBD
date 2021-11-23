using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccedoDatos;
using Entidades;

namespace Manejadores
{
    public class ManejadorPartida
    {
        AccesoBase _base;
        public ManejadorPartida()
        {
            _base = new AccesoBase("localhost", "root", "", "ajedrez", 3306);
        }
        public void Add(EntidadPartida ep)
        {
            _base.Consultar(string.Format("CALL p_AddPartida({0},'{1}','{2}',{3},{4},{5},{6},{7});", ep._CodigoP, ep._Fecha, ep._Jornada, ep._JugadorB, ep._JugadorN, ep._FKAlbitro, ep._FKSala, ep._Ganador));
        }
        public void Del(EntidadPartida ep)
        {
            _base.Consultar(string.Format("CALL p_DelPartida({0});", ep._CodigoP));
        }
        public void Upd(EntidadPartida ep)
        {
            _base.Consultar(string.Format("CALL p_UpdPartida({0},'{1}','{2}',{3},{4},{5},{6},{7});", ep._CodigoP, ep._Fecha, ep._Jornada, ep._JugadorB, ep._JugadorN, ep._FKAlbitro, ep._FKSala, ep._Ganador));
        }
        public void Show(DataGridView tabla, string dato)
        {
            tabla.DataSource = _base.ObtenerDatos(string.Format("SELECT * FROM partida WHERE Codigo_P LIKE '%{0}%';", dato), "partida").Tables["partida"];
            tabla.AutoResizeColumns();
        }
    }
}
