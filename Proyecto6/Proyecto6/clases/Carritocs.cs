using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto6.clases
{
    internal class Carritocs
    {

        private int carritocs_id;
        private int carritocs_cantidad;
        private DateTime carrito_fecha;

        public int Carritocs_id { get => carritocs_id; set => carritocs_id = value; }
        public int Carritocs_cantidad { get => carritocs_cantidad; set => carritocs_cantidad = value; }
        public DateTime Carrito_fecha { get => carrito_fecha; set => carrito_fecha = value; }

        public Carritocs()
        {
        }

        public Carritocs(int carritocs_id, int carritocs_cantidad, DateTime carrito_fecha)
        {
            this.carritocs_id = carritocs_id;
            this.carritocs_cantidad = carritocs_cantidad;
            this.carrito_fecha = carrito_fecha;
        }
    }
}
