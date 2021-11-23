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
    public class ManejadorParticipantes
    {
        AccesoBase _base;
        public ManejadorParticipantes()
        {
            _base = new AccesoBase("localhost", "root", "", "ajedrez", 3306);
        }
        public void Add(EntidadParticipantes ep)
        {
            _base.Consultar(string.Format("CALL p_AddParticipantes({0},'{1}','{2}','{3}',{4},'{5}');", ep._IDParticipante, ep._Nombre, ep._Direccion, ep._Telefono, ep._FKPais, ep._Campeonato));
        }
        public void Del(EntidadParticipantes ep)
        {
            _base.Consultar(string.Format("CALL p_DelParticipantes({0});", ep._IDParticipante));
        }
        public void Upd(EntidadParticipantes ep)
        {
            _base.Consultar(string.Format("CALL p_UpdParticipantes({0},'{1}','{2}','{3}',{4},'{5}');", ep._IDParticipante, ep._Nombre, ep._Direccion, ep._Telefono, ep._FKPais, ep._Campeonato));
        }
        public void Show(DataGridView tabla, string dato)
        {
            tabla.DataSource = _base.ObtenerDatos(string.Format("SELECT * FROM participantes WHERE id_Participante LIKE '%{0}%';", dato), "participantes").Tables["participantes"];
            tabla.AutoResizeColumns();
        }
    }
}
