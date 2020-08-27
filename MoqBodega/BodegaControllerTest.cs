using Castle.Core.Logging;
using System;
using System.Collections.Generic;

namespace MoqBodega
{
    public class BodegaControllerTest
    {
        readonly IBodega _bodega;
        readonly ILogger _logger;

        public BodegaControllerTest(IBodega bodega , ILogger logger = null)
        {
            _bodega = bodega;
            _logger = logger;
        }
        
        public Bodega AddBodegaMethodTest(string nombre, int cantidad)
        {
            try
            {
                _bodega.Add(nombre,cantidad);
                //var c = _repo.Find(id);
                return _bodega.Find(nombre);

            }
            catch (Exception ex)
            {
                _logger.Error("Oops", ex);
                throw;
            }
        }


    }
}
