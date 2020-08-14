using System;

namespace Restaurante
{
    public class Negocio
    {
        public int[,] mesas = new int[3, 3];
        string[] meseros = {};
        string[] platillos = {};

        public bool CheckMesas(int[,] mesa)
        {
            matrizA.GetLength(1)

        for (int i = 0; i < mesa.GetLength(0); i++)
            {
                for (int j = 0; j < mesa.GetLength(0); j++)
                {
                    int temp = 0;
                    for (int k = 0; k < matACols; k++)
                    {
                        temp += matrizA[i, k] * matrizB[k, j];
                    }
                    resultado[i, j] = temp;
                }
            }


        }

            return resultado;

    }
}
