using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto6.clases
{
    internal class Usuario
    {

        private int usuario_id;
        private String usuario_contraseña;
        private Boolean usuario_estadocuenta;
        private DateTime usuario_fecharegistro;

        public int Usuario_id { get => usuario_id; set => usuario_id = value; }
        public string Usuario_contraseña { get => usuario_contraseña; set => usuario_contraseña = value; }
        public bool Usuario_estadocuenta { get => usuario_estadocuenta; set => usuario_estadocuenta = value; }
        public DateTime Usuario_fecharegistro { get => usuario_fecharegistro; set => usuario_fecharegistro = value; }

        public Usuario()
        {
        }

        public Usuario(int usuario_id, string usuario_contraseña, bool usuario_estadocuenta, DateTime usuario_fecharegistro)
        {
            this.usuario_id = usuario_id;
            this.usuario_contraseña = usuario_contraseña;
            this.usuario_estadocuenta = usuario_estadocuenta;
            this.usuario_fecharegistro = usuario_fecharegistro;
        }
    }
}
