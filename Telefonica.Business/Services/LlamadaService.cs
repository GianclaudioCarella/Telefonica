using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telefonica.Business.Enums;
using Telefonica.Business.Repositories;

namespace Telefonica.Business.Services
{
    public class LlamadaService : ILlamadaService
    {

        LlamadaRepository repo = new LlamadaRepository(new TelefonicaEntities());

        /// <summary>
        /// Calcula el costo de una llamada
        /// </summary>
        /// <param name="llamada"></param>
        /// <returns></returns>
        public double CalculaCosto(Llamada llamada)
        {
            double total = 0;

            //calcular cantidad de minutos de la llamada
            TimeSpan span = llamada.FinLlamada.Subtract(llamada.InicioLlamada);

            if (llamada.Usuario.Telefono.CodPais != llamada.Telefono.CodPais)
            {
                //LLAMADA INTERNACIONAL
                total += span.TotalMinutes * CostoLlamadas.Internacional;
            }
            else
            {
                if (llamada.Usuario.Telefono.Area != llamada.Telefono.Area)
                {
                    //LLAMADA LARGA DISTANCIA
                    total += span.TotalMinutes * CostoLlamadas.LargaDistancia;
                }
                else
                {
                    //LLAMADA LOCAL
                    total += span.TotalMinutes * CostoLlamadas.Local;
                }
            }

            return total;
        }

        public double CalculaCostoRange(DateTime inicio, DateTime fin)
        {
            IEnumerable<Llamada> lamadas = repo.GetAll().Where(la => la.InicioLlamada >= inicio && la.InicioLlamada <= fin).ToList();
            double total = 0;

            foreach (var item in lamadas)
            {
                total += CalculaCosto(item);
            }

            return total;
        }

    }
}
