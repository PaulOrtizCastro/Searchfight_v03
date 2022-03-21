using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searchfight.Motores
{
    public class Bing : Base, IMotorBusqueda
    {
        public int Search(string word)
        {
            string key = obtenerLlave("bingkey");
            string url = "https://api.cognitive.microsoft.com/bingcustomsearch/v7.0/search" + "?q=" + word + "&customconfig=0";
            AddHeader("Ocp-Apim-Subscription-Key", key);
            var result = GetResponse(url);
            return Convert.ToInt32(result["webPages"]["totalEstimatedMatches"]);
        }
    }
}
