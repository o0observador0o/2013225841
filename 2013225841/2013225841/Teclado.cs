using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013225841
{
    public class Teclado
    {
        public int MontoRetirar { get; private set; }

        public Teclado(int montoRetirar) {
            MontoRetirar = montoRetirar;
        }

        private int _idTeclado;
        private int _idDispensadorEfectivo;
        private int _idPantalla;
        
        public int idTeclado {
            get {
                return _idTeclado;
            }

            set {
                if (value > 0)
                    _idTeclado = value;
            }
        }


        public int idDispensadorEfectivo
        {
            get
            {
                return _idDispensadorEfectivo;
            }

            set
            {
                if (value > 0)
                    _idDispensadorEfectivo = value;
            }
        }


        public int idPantalla
        {
            get
            {
                return _idPantalla;
            }

            set
            {
                if (value > 0)
                    _idPantalla = value;
            }
        }





    }
}
