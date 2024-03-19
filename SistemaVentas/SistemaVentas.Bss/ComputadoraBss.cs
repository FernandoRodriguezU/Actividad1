using SistemaVentas.Dal;
using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Bss
{
    public  class ComputadoraBss
    {
        ComputadoraDal dal = new ComputadoraDal();
        public DataTable ListarComputadoraBss()
        {

            return dal.ListarComputadoraDal();
        }
        public void InsertarComputadoraBss(Computadora computadora)
        {
            dal.InsertarComputadoraDAL(computadora);
        }
    }
}
