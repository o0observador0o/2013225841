using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013225841
{
    public class BaseDatos
    {
       
        List<RanuraDeposito> _RanuraDeposito;
        List<Teclado> _Teclado;
        List<DispensadorEfectivo> _DispensadorEfectivo;
        List<Pantalla> _Pantalla;

        public ATM ATM { get; set; }

        public BaseDatos() {
            _RanuraDeposito = new List<RanuraDeposito>();
            _Teclado = new List<Teclado>();
            _DispensadorEfectivo = new List<DispensadorEfectivo>();
            _Pantalla = new List<Pantalla>();
        }
        public BaseDatos(ATM atm) {
            ATM = atm;
        }

        private List<BaseDatos> _BaseDatos;
        public BaseDatos(int numBaseDatos) {
            _BaseDatos = new List<BaseDatos>(numBaseDatos);

        }


        public void AutenticarUsuario()
        {

            Console.WriteLine("Bienvenido");
            Console.WriteLine("Ingrese usuario: ");
            string username = Console.ReadLine();
            Console.WriteLine("Ingrese password: ");
            string password = "";
            ConsoleKeyInfo info = Console.ReadKey(true);
            while (info.Key != ConsoleKey.Enter)


            {
                if (info.Key != ConsoleKey.Backspace)
                {
                    password += info.KeyChar;
                    info = Console.ReadKey(true);
                }

                else if (info.Key == ConsoleKey.Backspace)
                {
                    if (!string.IsNullOrEmpty(password))
                    {
                        password = password.Substring(0, password.Length - 1);

                    }
                    info = Console.ReadKey(true);
                }

            }
            for (int i = 0; i < password.Length; i++)
                Console.Write("*");
            // return password;


        }




    }

   


}
