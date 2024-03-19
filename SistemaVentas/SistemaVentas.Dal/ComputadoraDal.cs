using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVentas.Modelos;

namespace SistemaVentas.Dal
{
    public class ComputadoraDal
    {
        public DataTable ListarComputadoraDal()
        {
            string consulta = "select * from computadora";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;

        }
        public void InsertarComputadoraDAL(Computadora computadora)
        {
            string consulta = "insert into computadora values('" + computadora.NOMBRE + "'," +
                                                          "'" + computadora.DESCRIPCION + "'," +
                                                          "'" + computadora.PRECIO + "'," +
                                                           " '" + computadora.FECHAFABRICACION + "')";
            conexion.Ejecutar(consulta);
        }

    }
}
