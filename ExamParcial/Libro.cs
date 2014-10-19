using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamParcial
{
    public class Libro
    {
        const int PRECIO_LIBRO = 8;
        const int COLECCION_PERCYJACKSON = 5;
        const double DESCUENTO_2 = 0.05;
        const double DESCUENTO_3 = 0.10;
        const double DESCUENTO_4 = 0.20;
        const double DESCUENTO_5 = 0.25;


        public double PrecioLibro(int[,] pedido)
        {
            int TamanioLista = 0;
            double precioFinal = 0;
            double precioPaquete = 0;
            double descuento = 0;

            List<int> Elemento = LlenaCarroDesdePedido(pedido);

            while (ExistenElementosEnArray(Elemento))
            {
                descuento = DameDescuento(Elemento);
                precioPaquete = PrecioPaquete(Elemento, descuento);
                precioFinal = precioFinal + precioPaquete;
                TamanioLista = Elemento.Count;
                EliminaLibrosPagados(Elemento, TamanioLista);
            }

            return precioFinal;
        }

        private void EliminaLibrosPagados(List<int> elemento, int tamanioCarro)
        {
            for (int i = tamanioCarro - 1; i >= 0; i--)
            {
                if (elemento[i] == 1)
                    elemento.Remove(elemento[i]);
                else
                    elemento[i]--;
            }
        }

        private double PrecioPaquete(List<int> elemento, double descuento)
        {
            return PRECIO_LIBRO * elemento.Count() * (1 - descuento);
        }

        private double DameDescuento(List<int> carro)
        {
            switch (carro.Count)
            {
                case 5:
                    return DESCUENTO_5;
                case 4:
                    return DESCUENTO_4;
                case 3:
                    return DESCUENTO_3;
                case 2:
                    return DESCUENTO_2;
                default:
                    return 0;
            }
        }

        private bool ExistenElementosEnArray(List<int> elemento)
        {
            return elemento.Count > 0;
        }

        private List<int> LlenaCarroDesdePedido(int[,] pedido)
        {
            List<int> carro = new List<int>();
            for (int i = 0; i < COLECCION_PERCYJACKSON; i++)
            {
                if (pedido[i, 0] == 1)
                {
                    carro.Add(pedido[i, 1]);
                }
            }
            return carro;
        }
    }
}

