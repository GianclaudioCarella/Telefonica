using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefonica.Business.Services
{
    public interface ILlamadaService
    {

        double CalculaCosto(Llamada llamada);

        double CalculaCostoRange(DateTime inicio, DateTime fin);

    }
}
