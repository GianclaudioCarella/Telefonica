using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefonica.Business.Services
{
    public interface ILlamadaService
    {
        /// <summary>
        /// Calcula el costo de una llamada
        /// </summary>
        /// <param name="llamada"></param>
        /// <returns></returns>
        double CalculaCosto(Llamada llamada);

        /// <summary>
        /// Calcula el costo de una llamada en un rango de fechas
        /// </summary>
        /// <param name="inicio"></param>
        /// <param name="fin"></param>
        /// <returns></returns>
        double CalculaCostoRange(DateTime inicio, DateTime fin);

    }
}
