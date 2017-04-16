using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013225841
{
    public class Cuenta
    {
        private int _BaseDatos;

        public int BaseDatos {
            get {
                return _BaseDatos;
            }

            set {
                if (value > 0)
                    _BaseDatos = value;
            }

         }

        public Cuenta(int basedatos) {
            BaseDatos = basedatos;
        }





    }
}
