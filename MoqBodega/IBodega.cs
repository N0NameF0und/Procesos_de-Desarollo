using System;

namespace MoqBodega
{
    public interface IBodega
    {

        Bodega Find(string nombre);

        void Add(string producto, int cantidad);


        int Inventario(string producto);


        bool HayStock(string producto, int cantidad);

        void Descargar(string producto);
    }
}
