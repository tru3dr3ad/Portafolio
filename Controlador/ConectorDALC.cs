using Modelo;

namespace Controlador
{
    public class ConectorDALC
    {
        private static AlmacenEntities _modeloAlmacen;
        public static AlmacenEntities ModeloAlmacen
        {
            get
            {
                if (_modeloAlmacen == null)
                {
                    _modeloAlmacen = new AlmacenEntities();
                }
                return _modeloAlmacen;
            }
        }
        public ConectorDALC()
        {

        }

    }
}
