using System;
using System.Collections.Generic;

namespace MoqBodega
{
    public class Bodega : IBodega
    {
        public List<string> productos = new List<string>();

        public List<int> cantidades = new List<int>();

        public Bodega()
        {
      
        }

        public void Add(string producto, int cantidad)
        {
            productos.Add(producto);
            cantidades.Add(cantidad);
        }

        public void Descargar(string producto)
        {

            int index = productos.FindIndex(a => a.Contains(producto));

            productos.RemoveAt(index);

        }
        

        public bool HayStock(string producto, int cantidad)
        {
            throw new NotImplementedException();
        }

        public int Inventario(string producto)
        {
            throw new NotImplementedException();
        }

        public int Rifar(string producto)
        {
            throw new NotImplementedException();
        }

        void IBodega.Add(string producto, int cantidad)
        {
            throw new NotImplementedException();
        }

        void IBodega.Descargar(string producto)
        {
            throw new NotImplementedException();
        }
    }
}
