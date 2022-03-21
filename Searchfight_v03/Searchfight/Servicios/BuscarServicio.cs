using Searchfight.Motores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searchfight.Servicios
{
    public abstract class BuscarServicio
    {
        public abstract string Name { get; }
        public int WinnerResults = 0;
        private string Winner = "No hay resultados";

        public abstract IMotorBusqueda CreateEngine();
        public string GetResults(string word)
        {
            IMotorBusqueda engine = CreateEngine();

            int results = engine.Search(word);

            SetWinner(word, results);

            return $"{Name} : {results}";
        }
        public string WinnerToString()
        {
            return $"{Name} winner : {Winner}";
        }
        private void SetWinner(string word, int results)
        {
            if (results > WinnerResults)
            {
                Winner = word;
                WinnerResults = results;
            }
        }
        public string GetWinner()
        {
            return Winner;
        }
    }
}
