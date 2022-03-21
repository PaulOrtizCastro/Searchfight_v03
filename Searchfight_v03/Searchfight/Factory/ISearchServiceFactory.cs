using Searchfight.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searchfight.Factory
{
    interface ISearchServiceFactory
    {
        BuscarServicio[] obtenerServicios();
        string obtenerGanador(BuscarServicio[] services);
    }
}
