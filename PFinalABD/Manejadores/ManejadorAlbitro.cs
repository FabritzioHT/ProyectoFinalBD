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
    public class ManejadorAlbitro
    {
        AccesoBase _base;
        public ManejadorAlbitro()
        {
            _base = new AccesoBase("localhost", "root", "", "ajedrez", 3306);
        }
        public void Add(EntidadAlbitro ea)
        {
            _base.Consultar(string.Format("CALL p_AddAlbitro({0},{1});", ea._IDAlbitro, ea._FKIDParticipante));
        }
        public void Del(EntidadAlbitro ea)
        {
            _base.Consultar(string.Format("CALL p_DelAlbitro({0});", ea._IDAlbitro));
        }
        public void Upd(EntidadAlbitro ea)
        {
            _base.Consultar(string.Format("CALL p_UpdAlbitro({0},{1});", ea._IDAlbitro, ea._FKIDParticipante));
        }
        public void Show(DataGridView tabla, string dato)
        {
            tabla.DataSource = _base.ObtenerDatos(string.Format("SELECT * FROM albitro WHERE id_Albitro LIKE '%{0}%';", dato), "albitro").Tables["albitro"];
            tabla.AutoResizeColumns();
        }
    }
}
