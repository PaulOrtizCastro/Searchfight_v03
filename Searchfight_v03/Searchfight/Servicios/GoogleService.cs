using Searchfight.Motores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searchfight.Servicios
{
    public class GoogleService: BuscarServicio
    {
        public override string Name => "Google";
        public override IMotorBusqueda CreateEngine()
        {
            return new Google();
        }
    }
}
