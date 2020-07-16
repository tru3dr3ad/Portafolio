﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class EstadoBoleta
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        
        #region Constructores
        public EstadoBoleta(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }
        public EstadoBoleta()
        {

        }
        #endregion

        #region Metodos
        public IList<EstadoBoleta> Listar()
        {
            List<EstadoBoleta> listado = new List<EstadoBoleta>();
            foreach (Modelo.ESTADO_BOLETA estadoBoleta in ConectorDALC.ModeloAlmacen.ESTADO_BOLETA.ToList())
            {
                EstadoBoleta estado = new EstadoBoleta();
                estado.Id = (int)estadoBoleta.IDESTADO;
                estado.Descripcion = estadoBoleta.DESCRIPCION;
                listado.Add(estado);
            }
            return listado;
        }
        public override string ToString()
        {
            return Descripcion;
        }
        public EstadoBoleta ObtenerEstadoBoleta(int id)
        {
            try
            {
                Modelo.ESTADO_BOLETA estadoModelo = ConectorDALC.ModeloAlmacen.ESTADO_BOLETA.FirstOrDefault(e => e.IDESTADO == id);
                Id = (int)estadoModelo.IDESTADO;
                Descripcion = estadoModelo.DESCRIPCION;
                EstadoBoleta estado = new EstadoBoleta(Id, Descripcion);
                return estado;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
        #endregion
    }
}
