using Searchfight.Factory;
using Searchfight.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searchfight.Configuracion
{
    class BuscarConfiguracionServicio : ISearchServiceFactory
    {
        public string obtenerGanador(BuscarServicio[] services)
        {
            List<string> winners = new List<string>();

            foreach (BuscarServicio service in services)
            {
                winners.Add(service.GetWinner());
            }
            return winners[1];
        }

        public BuscarServicio[] obtenerServicios()
        {
            return new BuscarServicio[] {
                new GoogleService(),
                new BingService()
            };
        }
    }
}
