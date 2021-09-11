using Examen_T1_CALIDAD;
using NUnit.Framework;
using System.Collections.Generic;

namespace Examen_T1_CALIDAD_TESTING
{
    public class Tests
    {

        [Test]

        public void CASO1()
        {
            Poker poker = new Poker();

            string [] jugadores = new string[] { "Jugador1", "Jugador2" , "Jugador3" };

            string[] cartas = new string[] { "Carta1", "Carta1", "Carta1", 
                                            "Carta1", "Carta1", "Carta1",
                                            "Carta1", "Carta1", "Carta1",
                                            "Carta1", "Carta1", "Carta1",
                                            "Carta1", "Carta1", "Carta1"};

            var resultadoEsperado = "jugadores aceptados";
            var resultadoReal = poker.validarJugadores(jugadores, cartas);

            Assert.AreEqual(resultadoReal, resultadoEsperado);

        }

        [Test]
        public void CASO2()
        {
            Poker poker = new Poker();

            string[] jugadores = new string[] { "Jugador1"};

            string[] cartas = new string[] { "Carta1", "Carta1", "Carta1",
                                            "Carta1", "Carta1" };

            var resultadoEsperado = "jugadores no aceptados";
            var resultadoReal = poker.validarJugadores(jugadores, cartas);

            Assert.AreEqual(resultadoReal, resultadoEsperado);

        }

        [Test]

        public void CASO3()
        {
            Poker poker = new Poker();

            string[] jugadores = new string[] { "Jugador1", "Jugador2"};

            string[] cartas = new string[] { "Carta1", "Carta1", "Carta1",
                                            "Carta1", "Carta1", "Carta1",
                                            "Carta1", "Carta1", "Carta1",
                                            "Carta1"};

            var resultadoEsperado = "jugadores aceptados";
            var resultadoReal = poker.validarJugadores(jugadores, cartas);

            Assert.AreEqual(resultadoReal, resultadoEsperado);

        }

        [Test]

        public void CASO4()
        {
            Poker poker = new Poker();

            string[] jugadores = new string[] { "Jugador1", "Jugador2" };

            string[] cartas = new string[] { "Carta1", "Carta1", "Carta1",
                                            "Carta1", "Carta1", "Carta1",
                                            "Carta1", "Carta1", "Carta1",
                                            "Carta1","Carta1","Carta1"};

            var resultadoEsperado = "cartas error";
            var resultadoReal = poker.validarCartas(jugadores, cartas);

            Assert.AreEqual(resultadoReal, resultadoEsperado);

        }

        [Test]
        public void CASO5()
        {
            Poker poker = new Poker();

            string[] jugadores = new string[] { "Jugador1", "Jugador2" , "Jugador3" };

            string[] cartas = new string[] { "Carta1", "Carta1", "Carta1",
                                            "Carta1", "Carta1", "Carta1",
                                            "Carta1", "Carta1", "Carta1",
                                            "Carta1","Carta1","Carta1",
                                            "Carta1","Carta1", "Carta1"};

            var resultadoEsperado = "cartas exactas";
            var resultadoReal = poker.validarCartas(jugadores, cartas);

            Assert.AreEqual(resultadoReal, resultadoEsperado);

        }

        [Test]
        public void CASO6()
        {
            Poker poker = new Poker();

            string[] jugadores = new string[] { "Jugador1", "Jugador2", "Jugador3" };

            List<string> cartas = new List<string>()
                                            { "Carta1", "Carta1", "Carta1",
                                            "Carta1", "Carta1", "Carta1",
                                            "Carta1", "Carta1", "Carta1",
                                            "Carta1","Carta1","Carta1",
                                            "Carta1","Carta1", "Carta1"};

            var resultadoEsperado = "cartas duplicadas";
            var resultadoReal = poker.validarCartasIguales(jugadores, cartas);

            Assert.AreEqual(resultadoReal, resultadoEsperado);

        }

        [Test]
        public void CASO7()
        {
            Poker poker = new Poker();

            string[] jugadores = new string[] { "Jugador1", "Jugador2", "Jugador3" };

            List<string> cartas = new List<string>()
                                            { "Carta1", "Carta2", "Carta3",
                                            "Carta4", "Carta5", "Carta6",
                                            "Carta7", "Carta8", "Carta9",
                                            "Carta10","Carta11","Carta12",
                                            "Carta13","Carta14", "Carta15"};

            var resultadoEsperado = "cartas sin duplicar";
            var resultadoReal = poker.validarCartasIguales(jugadores, cartas);

            Assert.AreEqual(resultadoReal, resultadoEsperado);

        }



    }
}