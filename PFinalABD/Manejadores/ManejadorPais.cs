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
    public class ManejadorPais
    {
        AccesoBase _base;
        public ManejadorPais()
        {
            _base = new AccesoBase("localhost", "root", "", "ajedrez", 3306);
        }
        public void Add(EntidadPais ep)
        {
            _base.Consultar(string.Format("CALL p_AddPais({0},'{1}',{2},{3});", ep._IDPais, ep._Nombre, ep._NClubes, ep._FKIDPais));
        }
        public void Del(EntidadPais ep)
        {
            _base.Consultar(string.Format("CALL p_DelPais({0});", ep._IDPais));
        }
        public void Upd(EntidadPais ep)
        {
            _base.Consultar(string.Format("CALL p_UpdPais({0},'{1}',{2},{3});", ep._IDPais, ep._Nombre, ep._NClubes, ep._FKIDPais));
        }
        public void Show(DataGridView tabla, string dato)
        {
            tabla.DataSource = _base.ObtenerDatos(string.Format("SELECT * FROM pais WHERE id_Pais LIKE '%{0}%';", dato), "pais").Tables["pais"];
            tabla.AutoResizeColumns();
        }
    }
}
