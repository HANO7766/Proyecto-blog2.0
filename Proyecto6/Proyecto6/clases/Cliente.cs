using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto6.clases
{
    public class Cliente
    {

        private int cliente_id;
        public String cliente_direccion;
        private String cliente_correo;
        private String cliente_domicilio;
        private String cliente_tarjeta;

        public int Cliente_id { get => cliente_id; set => cliente_id = value; }
        public string Cliente_direccion { get => cliente_direccion; set => cliente_direccion = value; }
        public string Cliente_correo { get => cliente_correo; set => cliente_correo = value; }
        public string Cliente_domicilio { get => cliente_domicilio; set => cliente_domicilio = value; }
        public string Cliente_tarjeta { get => cliente_tarjeta; set => cliente_tarjeta = value; }

        public Cliente()
        {
        }

        public Cliente(int cliente_id, string cliente_direccion, string cliente_correo, string cliente_domicilio, string cliente_tarjeta)
        {
            this.cliente_id = cliente_id;
            this.cliente_direccion = cliente_direccion;
            this.cliente_correo = cliente_correo;
            this.cliente_domicilio = cliente_domicilio;
            this.cliente_tarjeta = cliente_tarjeta;
        }

        class Suma
        {
           
        }
    }
}
