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
    public class ManejadorJugador
    {
        AccesoBase _base;
        public ManejadorJugador()
        {
            _base = new AccesoBase("localhost", "root", "", "ajedrez", 3306);
        }
        public void Add(EntidadJugador ej)
        {
            _base.Consultar(string.Format("CALL p_AddJugador({0},{1});", ej._IDJugador, ej._FKIDParticipante));
        }
        public void Del(EntidadJugador ej)
        {
            _base.Consultar(string.Format("CALL p_DelJugador({0});", ej._IDJugador));
        }
        public void Upd(EntidadJugador ej)
        {
            _base.Consultar(string.Format("CALL p_UpdJugador({0},{1});", ej._IDJugador, ej._FKIDParticipante));
        }
        public void Show(DataGridView tabla, string dato)
        {
            tabla.DataSource = _base.ObtenerDatos(string.Format("SELECT * FROM jugador WHERE id_Jugador LIKE '%{0}%';", dato), "jugador").Tables["jugador"];
            tabla.AutoResizeColumns();
        }
    }
}
