using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013225841
{
    public class Retiro
    {
        public int RetiroId { get; private set; }
        public int NumeroCuenta { get; private set; }

        public int Monto { get; private set; }
        
        public Teclado Teclado { get; set; }

        public Retiro() {

        }

        public Retiro(Teclado teclado) {
            Teclado = teclado;
        }

        public Retiro(int retiroId) {
            RetiroId = RetiroId;
        }

        public void MontoRetiro() {
            NumeroCuenta = Teclado.MontoRetirar;
        }

        public DispensadorEfectivo DispensadorEfectivo { get; set; }

        public Pantalla Pantalla { get; set; }

        public ATM ATM { get; set;  }

        public BaseDatos BaseDatos { get; set; }




    }
}
