using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto6.clases
{
     class Trabajador
    {
        private int trabajador_id;
        private float trabajador_rut;
        private String trabajador_nombre;
        private String trabajdor_contraseña;

        public int Trabajador_id { get => trabajador_id; set => trabajador_id = value; }
        public float Trabajador_rut { get => trabajador_rut; set => trabajador_rut = value; }
        public string Trabajador_nombre { get => trabajador_nombre; set => trabajador_nombre = value; }
        public string Trabajdor_contraseña { get => trabajdor_contraseña; set => trabajdor_contraseña = value; }

        public Trabajador()
        {
        }

        public Trabajador(int trabajador_id, float trabajador_rut, string trabajador_nombre, string trabajdor_contraseña)
        {
            this.trabajador_id = trabajador_id;
            this.trabajador_rut = trabajador_rut;
            this.trabajador_nombre = trabajador_nombre;
            this.trabajdor_contraseña = trabajdor_contraseña;
        }

        public void TrabajadorAtributos() {

            Console.WriteLine("el nombre del trabajador es octavio..."); 
        }
    }
}
