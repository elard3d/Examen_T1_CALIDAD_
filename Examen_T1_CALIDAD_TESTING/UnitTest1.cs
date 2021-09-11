using Examen_T1_CALIDAD;
using NUnit.Framework;

namespace Examen_T1_CALIDAD_TESTING
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            Poker poker = new Poker();

            string [] jugadores = new string[] { "Jugador1", "Jugador2" , "Jugador3" };


           

            poker.jugar();
        }
    }
}