namespace Entidades
{
    public class EntidadAlbitro
    {
        public EntidadAlbitro()
        {
        }

        public EntidadAlbitro(int iDAlbitro, int fKIDParticipante)
        {
            _IDAlbitro = iDAlbitro;
            _FKIDParticipante = fKIDParticipante;
        }

        public int _IDAlbitro { get; set; }
        public int _FKIDParticipante { get; set; }
    }
}
