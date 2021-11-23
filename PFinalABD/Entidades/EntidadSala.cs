namespace Entidades
{
    public class EntidadSala
    {
        public EntidadSala()
        {
        }

        public EntidadSala(int iDSala, string codigo, string capacidad, string medio, string fKHotel)
        {
            _IDSala = iDSala;
            _Codigo = codigo;
            _Capacidad = capacidad;
            _Medio = medio;
            _FKHotel = fKHotel;
        }

        public int _IDSala { get; set; }
        public string _Codigo { get; set; }
        public string _Capacidad { get; set; }
        public string _Medio { get; set; }
        public string _FKHotel { get; set; }
    }
}
