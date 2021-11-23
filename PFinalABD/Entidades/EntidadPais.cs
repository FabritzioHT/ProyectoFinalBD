namespace Entidades
{
    public class EntidadPais
    {
        public EntidadPais()
        {
        }

        public EntidadPais(int iDPais, string nombre, int nClubes, int fKIDPais)
        {
            _IDPais = iDPais;
            _Nombre = nombre;
            _NClubes = nClubes;
            _FKIDPais = fKIDPais;
        }

        public int _IDPais { get; set; }
        public string _Nombre { get; set; }
        public int _NClubes { get; set; }
        public int _FKIDPais { get; set; }
    }
}
