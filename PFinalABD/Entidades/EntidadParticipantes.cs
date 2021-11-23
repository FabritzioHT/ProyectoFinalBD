namespace Entidades
{
    public class EntidadParticipantes
    {
        public EntidadParticipantes()
        {
        }

        public EntidadParticipantes(int iDParticipante, string nombre, string direccion, string telefono, int fKPais, string campeonato)
        {
            _IDParticipante = iDParticipante;
            _Nombre = nombre;
            _Direccion = direccion;
            _Telefono = telefono;
            _FKPais = fKPais;
            _Campeonato = campeonato;
        }

        public int _IDParticipante { get; set; }
        public string _Nombre { get; set; }
        public string _Direccion { get; set; }
        public string _Telefono { get; set; }
        public int _FKPais { get; set; }
        public string _Campeonato { get; set; }
    }
}
