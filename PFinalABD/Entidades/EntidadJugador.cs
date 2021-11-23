namespace Entidades
{
    public class EntidadJugador
    {
        public EntidadJugador()
        {
        }

        public EntidadJugador(int iDJugador, int fKIDParticipante)
        {
            _IDJugador = iDJugador;
            _FKIDParticipante = fKIDParticipante;
        }

        public int _IDJugador { get; set; }
        public int _FKIDParticipante { get; set; }
    }
}
