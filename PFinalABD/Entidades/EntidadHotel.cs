namespace Entidades
{
    public class EntidadHotel
    {
        public EntidadHotel()
        {
        }

        public EntidadHotel(string nombre, string direccion, string telefono)
        {
            _Nombre = nombre;
            _Direccion = direccion;
            _Telefono = telefono;
        }

        public string _Nombre { get; set; }
        public string _Direccion { get; set; }
        public string _Telefono { get; set; }
    }
}
