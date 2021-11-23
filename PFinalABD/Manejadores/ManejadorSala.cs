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
    public class ManejadorSala
    {
        AccesoBase _base;
        public ManejadorSala()
        {
            _base = new AccesoBase("localhost", "root", "", "ajedrez", 3306);
        }
        public void Add(EntidadSala es)
        {
            _base.Consultar(string.Format("CALL p_AddSala({0},'{1}','{2}','{3}','{4}');", es._IDSala, es._Codigo, es._Capacidad, es._Medio, es._FKHotel));
        }
        public void Del(EntidadSala es)
        {
            _base.Consultar(string.Format("CALL p_DelSala({0});", es._IDSala));
        }
        public void Upd(EntidadSala es)
        {
            _base.Consultar(string.Format("CALL p_UpdSala({0},'{1}','{2}','{3}','{4}');", es._IDSala, es._Codigo, es._Capacidad, es._Medio, es._FKHotel));
        }
        public void Show(DataGridView tabla, string dato)
        {
            tabla.DataSource = _base.ObtenerDatos(string.Format("SELECT * FROM sala WHERE id_Sala LIKE '%{0}%';", dato), "sala").Tables["sala"];
            tabla.AutoResizeColumns();
        }
    }
}
