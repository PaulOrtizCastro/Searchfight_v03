using Searchfight.Motores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searchfight.Servicios
{
    class BingService: BuscarServicio
    {
        public override string Name => "Bing";
        public override IMotorBusqueda CreateEngine()
        {
            return new Bing();
        }
    }
}
