using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013225841
{
    public class RanuraDeposito
    {
        private int _IdRanuraDeposito;

        public int IdRanuraDeposito {
            get {
                return _IdRanuraDeposito;
            }
            set
            {
                if (value > 0)
                    _IdRanuraDeposito = value;
            }


        }

        public RanuraDeposito(int idRanuraDeposito) {
            IdRanuraDeposito = idRanuraDeposito;
        }

    }
}
