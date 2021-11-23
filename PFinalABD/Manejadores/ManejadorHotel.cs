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
    public class ManejadorHotel
    {
        AccesoBase _base;
        public ManejadorHotel()
        {
            _base = new AccesoBase("localhost", "root", "", "ajedrez", 3306);
        }
        public void Add(EntidadHotel eh)
        {
            _base.Consultar(string.Format("CALL p_AddHotel('{0}','{1}','{2}');", eh._Nombre, eh._Direccion, eh._Telefono));
        }
        public void Del(EntidadHotel eh)
        {
            _base.Consultar(string.Format("CALL p_DelHotel('{0}');", eh._Nombre));
        }
        public void Upd(EntidadHotel eh)
        {
            _base.Consultar(string.Format("CALL p_UpdHotel('{0}','{1}','{2}');", eh._Nombre, eh._Direccion, eh._Telefono));
        }
        public void Show(DataGridView tabla, string dato)
        {
            tabla.DataSource = _base.ObtenerDatos(string.Format("SELECT * FROM hotel WHERE Nombre LIKE '%{0}%';", dato), "hotel").Tables["hotel"];
            tabla.AutoResizeColumns();
        }
    }
}
