using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examen_T1_CALIDAD
{
    public class Poker
    {
        public string validarJugadores(Array jugadores, Array cartas)
        {

            if (jugadores.Length < 2)
            {

                return "jugadores no aceptados";

            }
            else
            {
                return "jugadores aceptados";

            }



        }

        public string validarCartas(Array jugadores, Array cartas)
        {

            if (jugadores.Length * 5 == cartas.Length)
            {

                return "cartas exactas";

            }
            else
            {

                return "cartas error";

            }


        }

        public string validarCartasIguales(Array jugadores, List<String> cartas)
        {

            var duplicados = 0;

            foreach (var grouping in cartas.GroupBy(t => t).Where(t => t.Count() != 1))
            {
             
                duplicados += grouping.Count();

            }

            if (duplicados >= 1)
            {
                return "cartas duplicadas";
            }
            else
            {
                return "cartas sin duplicar";
            }


        }
    }
}
