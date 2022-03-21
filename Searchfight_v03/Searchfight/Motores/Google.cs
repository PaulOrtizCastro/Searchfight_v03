using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searchfight.Motores
{
    public class Google : Base, IMotorBusqueda
    {
        public int Search(string word)
        {
            string key = obtenerLlave("googlekey");
            string url = "https://www.googleapis.com/customsearch/v1?key=" + key + "&q=" + word;
            var result = GetResponse(url);
            return Convert.ToInt32(result["queries"]["request"][0]["totalResults"]);
        }        
    }
}
