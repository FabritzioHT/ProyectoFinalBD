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
    public class ManejadorMovimiento
    {
        AccesoBase _base;
        public ManejadorMovimiento()
        {
            _base = new AccesoBase("localhost", "root", "", "ajedrez", 3306);
        }
        public void Add(EntidadMovimiento em)
        {
            _base.Consultar(string.Format("CALL p_AddMovimiento({0},{1},'{2}','{3}',{4},{5},'{6}');", em._Movimiento, em._IDPartida, em._Jugada, em._Comentario, em._JugadorB, em._JugadorN, em._Fecha));
        }
        public void Del(EntidadMovimiento em)
        {
            _base.Consultar(string.Format("CALL p_DelMovimiento({0});", em._Movimiento));
        }
        public void Upd(EntidadMovimiento em)
        {
            _base.Consultar(string.Format("CALL p_UpdMovimiento({0},{1},'{2}','{3}',{4},{5},'{6}');", em._Movimiento, em._IDPartida, em._Jugada, em._Comentario, em._JugadorB, em._JugadorN, em._Fecha));
        }
        public void Show(DataGridView tabla, string dato)
        {
            tabla.DataSource = _base.ObtenerDatos(string.Format("SELECT * FROM movimiento WHERE id_Movimiento LIKE '%{0}%';", dato), "movimiento").Tables["movimiento"];
            tabla.AutoResizeColumns();
        }
    }
}
