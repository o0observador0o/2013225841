using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013225841
{
    public class ATM
    {
        private List<RanuraDeposito> _RanuraDeposito;
        private List<Teclado> _Teclado;
        private List<DispensadorEfectivo> _DispensadorEfectivo;
        private List<Pantalla> _Pantalla;

        public ATM(int idRanuraDeposito, int idTeclado, int idDispensadorEfectivo, int idPantalla) {
            _RanuraDeposito = new List<RanuraDeposito>(idRanuraDeposito);
            _Teclado = new List<Teclado>(idTeclado);
            _DispensadorEfectivo = new List<DispensadorEfectivo>(idDispensadorEfectivo);
            _Pantalla = new List<Pantalla>(idPantalla);


        }




        
        



    }
}
