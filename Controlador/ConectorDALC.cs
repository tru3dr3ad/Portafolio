using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
