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
    public class ManejadorRegistro
    {
        AccesoBase _base;
        public ManejadorRegistro()
        {
            _base = new AccesoBase("localhost", "root", "", "ajedrez", 3306);
        }
        public void Add(EntidadRegistro er)
        {
            _base.Consultar(string.Format("CALL p_AddRegistro({0},'{1}','{2}',{3},'{4}');", er._IDAlojo, er._FEntrada, er._FSalida, er._FKParticipante, er._FKHotel));
        }
        public void Del(EntidadRegistro er)
        {
            _base.Consultar(string.Format("CALL p_DelRegistro({0});", er._IDAlojo));
        }
        public void Upd(EntidadRegistro er)
        {
            _base.Consultar(string.Format("CALL p_UpdRegistro({0},'{1}','{2}',{3},'{4}');", er._IDAlojo, er._FEntrada, er._FSalida, er._FKParticipante, er._FKHotel));
        }
        public void Show(DataGridView tabla, string dato)
        {
            tabla.DataSource = _base.ObtenerDatos(string.Format("SELECT * FROM registro WHERE id_Alojo LIKE '%{0}%';", dato), "registro").Tables["registro"];
            tabla.AutoResizeColumns();
        }
    }
}
