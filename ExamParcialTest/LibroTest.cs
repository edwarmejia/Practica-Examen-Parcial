using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ExamParcial;

namespace ExamParcialTest
{
    [TestFixture]
    public class LibroTest
    {
        [Test]
        public void No_Compramos_Nada()
        {
            Libro  SUT = new Libro();
           int[,] pedido = new int[,] { { 0, 0 }, { 0, 0 }, { 0, 0 }, { 0, 0 }, { 0, 0 }};

           double resultado = SUT.PrecioLibro(pedido);
            Assert.AreEqual(resultado, 0);
            
        }
        [Test]
        public void Compramos_Un_Libro()
        {
            Libro SUT = new Libro();
            int[,] pedido = new int[,] { { 1, 1 }, { 0, 0 }, { 0, 0 }, { 0, 0 }, { 0, 0 }};

            double resultado = SUT.PrecioLibro(pedido);
            Assert.AreEqual(resultado, 8);

        }
        [Test]
        public void Compramos_5_Libros()
        {
            Libro SUT = new Libro();
            int[,] pedido = new int[,] { { 1,5 }, { 0, 0 }, { 0, 0 }, { 0, 0 }, { 0,0 } };

            double resultado = SUT.PrecioLibro(pedido);
            Assert.AreEqual(resultado, 40);

        }
        [Test]
        public void Compramos_2_libro_Con_Descuento()
        {
            Libro SUT = new Libro();
            int[,] pedido = new int[,] { { 1, 1 }, { 1 ,1 }, { 0, 0 }, { 0, 0 }, { 0, 0 } };

            double resultado = SUT.PrecioLibro(pedido);
            Assert.AreEqual(Math.Ceiling(resultado), 16);

        }
        [Test]
        public void Compramos_3_libro_Con_Descuento()
        {
            Libro SUT = new Libro();
            int[,] pedido = new int[,] { { 1, 1 }, { 1, 1 }, { 1, 1 }, { 0, 0 }, { 0, 0 } };

            double resultado = SUT.PrecioLibro(pedido);
            Assert.AreEqual(resultado,21.6);

        }
        [Test]
        public void Compramos_4_libro_Con_Descuento()
        {
            Libro SUT = new Libro();
            int[,] pedido = new int[,] { { 1, 1 }, { 1, 1 }, { 1, 1 }, { 1, 1 }, { 0, 0 } };

            double resultado = SUT.PrecioLibro(pedido);
            Assert.AreEqual(resultado, 25.6);

        }
        [Test]
        public void Compramos_5_libro_Con_Descuento()
        {
            Libro SUT = new Libro();
            int[,] pedido = new int[,] { { 1, 1 }, { 1, 1 }, { 1, 1 }, { 1, 1 }, { 1, 1 } };

            double resultado = SUT.PrecioLibro(pedido);
            Assert.AreEqual(resultado, 30);

        }
        [Test]
        public void Compramos__libro_22211()
        {
            Libro SUT = new Libro();
            int[,] pedido = new int[,] { { 1, 2 }, { 1, 2 }, { 1, 2 }, { 1, 1 }, { 1, 1 } };

            double resultado = SUT.PrecioLibro(pedido);
            Assert.AreEqual(resultado, 51.60);

        }
        [Test]
        public void Compramos__libro_2222()
        {
            Libro SUT = new Libro();
            int[,] pedido = new int[,] { { 1, 2 }, { 1, 2 }, { 1, 2 }, { 1, 2 }, { 0, 0 } };

            double resultado = SUT.PrecioLibro(pedido);
            Assert.AreEqual(resultado, 51.20);

        }
        [Test]
        public void Compramos__libro_22333()
        {
            Libro SUT = new Libro();
            int[,] pedido = new int[,] { { 1, 2 }, { 1, 3 }, { 1, 2 }, { 1, 3 }, { 1, 3 } };

            double resultado = SUT.PrecioLibro(pedido);
            Assert.AreEqual(Math.Ceiling(resultado), 82);

        }
        [Test]
        public void Compramos__libro_12345()
        {
            Libro SUT = new Libro();
            int[,] pedido = new int[,] { { 1, 1 }, { 1, 2 }, { 1, 3 }, { 1, 4 }, { 1, 5} };

            double resultado = SUT.PrecioLibro(pedido);
            Assert.AreEqual((resultado), 100.4);

        }
        [Test]
        public void Compramos_una_Coleccion()
        {
            Libro SUT = new Libro();
            int[,] pedido = new int[,] { {1, 1 }, {1, 1 }, {1, 1}, { 1,1 }, { 1,1 } };

            double resultado = SUT.PrecioLibro(pedido);
            Assert.AreEqual((resultado), 30);

        }

        [Test]
        public void Compramos_Final()
        {
            Libro SUT = new Libro();
            int[,] pedido = new int[,] { { 1, 6 }, { 1, 5 }, { 1, 4 }, { 1,3 }, { 1, 2 }  };

            double resultado = SUT.PrecioLibro(pedido);
            Assert.AreEqual(Math.Ceiling(resultado), 131);

        }
    }
}
    
             
            
        
        /*



        public class Compramos_7_Del_1_6_Del_2_5_Del_3_4_Del_4_3_Del_5_2_Del_6_1_Del_7
        {
            KataPotter.IKataPotter SUT = new KataPotter.KataPotter();
            private double resultado;
            int[,] pedido = new int[,] { { 1, 7 }, { 1, 6 }, { 1, 5 }, { 1, 4 }, { 1, 3 }, { 1, 2 }, { 1, 1 } };

            [SetUp]
            public void Setup()
            {
                resultado = SUT.PrecioLibro(pedido);
            }

            [Test]
            public void Devuelve_Precio()
            {
                Assert.AreEqual(resultado,
                    (8 * 7 * 0.55) + (8 * 6 * 0.70) + (8 * 5 * 0.80) +
                    (8 * 4 * 0.85) + (8 * 3 * 0.90) + (8 * 2 * 0.95) + (8 * 1 * 1));
            }
        }
    }
    */
    

