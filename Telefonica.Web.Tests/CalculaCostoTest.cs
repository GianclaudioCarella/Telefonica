using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Telefonica.Business;
using Telefonica.Business.Services;

namespace Telefonica.Web.Tests
{
    [TestClass]
    public class CalculaCostoTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //double totalIntEsperado = 10.20;
            ////double dif = 10.20;

            //DateTime inicio = new DateTime(2017, 12, 12, 14, 19, 10); // 12/12/2017  14:19:10
            //DateTime fin = new DateTime(2017, 12, 12, 14, 29, 30); // 12/12/2017  14:29:30
            //TimeSpan span = fin.Subtract(inicio);

            ////llamada internacional
            //double totalint = span.TotalMinutes * 1;

            //LlamadaService srv = new LlamadaService();
            //Telefono tel = new Telefono();
            //tel.CodPais = 55;
            //Usuario user = new Usuario();
            //user.Telefono = tel;

            //Llamada llamada = new Llamada();
            //llamada.InicioLlamada = inicio;
            //llamada.FinLlamada = fin;
            //llamada.Usuario = user;
            //Telefono telDestino = new Telefono();
            //telDestino.CodPais = 54;
            //llamada.Telefono = telDestino;

            //double resultado = srv.CalculaCosto(llamada);

            //// assert
            //Assert.AreEqual(totalint, resultado, 0.001, "La cuenta no esta correcta");
        }

        [TestMethod]
        public void TestMethod2()
        {
            //double totalldEsperado = 5.1;
            ////double dif = 10.20;

            //DateTime inicio = new DateTime(2017, 12, 12, 14, 19, 10); // 12/12/2017  14:19:10
            //DateTime fin = new DateTime(2017, 12, 12, 14, 29, 30); // 12/12/2017  14:29:30
            //TimeSpan span = fin.Subtract(inicio);

            ////llamada longa distancia
            //double totalld = span.TotalMinutes * 0.5;

            //LlamadaService srv = new LlamadaService();
            //Telefono tel = new Telefono();
            //tel.Area = 15;
            //Usuario user = new Usuario();
            //user.Telefono = tel;

            //Llamada llamada = new Llamada();
            //llamada.InicioLlamada = inicio;
            //llamada.FinLlamada = fin;
            //llamada.Usuario = user;
            //Telefono telDestino = new Telefono();
            //telDestino.Area = 13;
            //llamada.Telefono = telDestino;

            //double resultado = srv.CalculaCosto(llamada);

            //// assert
            //Assert.AreEqual(totalld, resultado, 0.001, "La cuenta no esta correcta");
        }

        [TestMethod]
        public void TestMethod3()
        {
            //double totalLocalEsperado = 1.02;
            ////double dif = 10.20;

            //DateTime inicio = new DateTime(2017, 12, 12, 14, 19, 10); // 12/12/2017  14:19:10
            //DateTime fin = new DateTime(2017, 12, 12, 14, 29, 30); // 12/12/2017  14:29:30
            //TimeSpan span = fin.Subtract(inicio);

            ////llamada local
            //double totallocal = span.TotalMinutes * 0.1;

            //LlamadaService srv = new LlamadaService();
            //Telefono tel = new Telefono();
            //tel.CodPais = 55;
            //tel.Area = 15;
            //Usuario user = new Usuario();
            //user.Telefono = tel;

            //Llamada llamada = new Llamada();
            //llamada.InicioLlamada = inicio;
            //llamada.FinLlamada = fin;
            //llamada.Usuario = user;
            //Telefono telDestino = new Telefono();
            //telDestino.CodPais = 55;
            //telDestino.Area = 15;
            //llamada.Telefono = telDestino;

            //double resultado = srv.CalculaCosto(llamada);

            //// assert
            //Assert.AreEqual(totallocal, resultado, 0.001, "La cuenta no esta correcta");
        }

    }
}
