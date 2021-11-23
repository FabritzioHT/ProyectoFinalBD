namespace Entidades
{
    public class EntidadMovimiento
    {
        public EntidadMovimiento()
        {
        }

        public EntidadMovimiento(int movimiento, int iDPartida, string jugada, string comentario, int jugadorB, int jugadorN, string fecha)
        {
            _Movimiento = movimiento;
            _IDPartida = iDPartida;
            _Jugada = jugada;
            _Comentario = comentario;
            _JugadorB = jugadorB;
            _JugadorN = jugadorN;
            _Fecha = fecha;
        }

        public int _Movimiento { get; set; }
        public int _IDPartida { get; set; }
        public string _Jugada { get; set; }
        public string _Comentario { get; set; }
        public int _JugadorB { get; set; }
        public int _JugadorN { get; set; }
        public string _Fecha { get; set; }
    }
}
