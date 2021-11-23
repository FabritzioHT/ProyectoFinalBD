namespace Entidades
{
    public class EntidadPartida
    {
        public EntidadPartida()
        {
        }

        public EntidadPartida(int codigoP, string fecha, string jornada, int jugadorN, int jugadorB, int fKAlbitro, int fKSala, int ganador)
        {
            _CodigoP = codigoP;
            _Fecha = fecha;
            _Jornada = jornada;
            _JugadorN = jugadorN;
            _JugadorB = jugadorB;
            _FKAlbitro = fKAlbitro;
            _FKSala = fKSala;
            _Ganador = ganador;
        }

        public int _CodigoP { get; set; }
        public string _Fecha { get; set; }
        public string _Jornada { get; set; }
        public int _JugadorN { get; set; }
        public int _JugadorB { get; set; }
        public int _FKAlbitro { get; set; }
        public int _FKSala { get; set; }
        public int _Ganador { get; set; }
    }
}
