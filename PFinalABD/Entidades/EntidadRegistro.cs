namespace Entidades
{
    public class EntidadRegistro
    {
        public EntidadRegistro()
        {
        }

        public EntidadRegistro(int iDAlojo, string fEntrada, string fSalida, int fKParticipante, string fKHotel)
        {
            _IDAlojo = iDAlojo;
            _FEntrada = fEntrada;
            _FSalida = fSalida;
            _FKParticipante = fKParticipante;
            _FKHotel = fKHotel;
        }

        public int _IDAlojo { get; set; }
        public string _FEntrada { get; set; }
        public string _FSalida { get; set; }
        public int _FKParticipante { get; set; }
        public string _FKHotel { get; set; }
    }
}
