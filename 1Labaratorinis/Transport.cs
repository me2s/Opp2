using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Labaratorinis
{
    /// <summary>
    /// Class that describes data of a transport vehicle
    /// </summary>
    class Transport
    {
        public int Number { get; set; }
        public string Route { get; set; }
        public int Distance { get; set; }
        public int Stops { get; set; }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="number">Route number</param>
        /// <param name="route">Route name</param>
        /// <param name="distance">Route distance</param>
        /// <param name="stops">Route stops</param>
        public Transport(int number, string route, int distance, int stops)
        {
            this.Number = number;
            this.Route = route;
            this.Distance = distance;
            this.Stops = stops;
        }

        /// <summary>
        /// Overriden Object class method
        /// </summary>
        /// <returns>Concatenated string (all class properties)</returns>
        public override string ToString()
        {
            string line;
            line = string.Format("{0,-3}  | {1,-30}    | {2,4}    |{3,5}",Number, Route,
                                 Distance, Stops);
            return line;
        }

        /// <summary>
        /// Number of stops comparison method
        /// </summary>
        /// <param name="trans1">Vehicle 1 stops</param>
        /// <param name="trans2">Vehicle 2 stops</param>
        /// <returns>Trans1 if it has more stops than trans2</returns>
        public static bool operator > (Transport trans1, Transport trans2)
        {
            return trans1.Stops> trans2.Stops;
        }

        /// <summary>
        /// Number of stops comparison method
        /// </summary>
        /// <param name="trans1">Vehicle 1 stops</param>
        /// <param name="trans2">Vehicle 2 stops</param>
        /// <returns>Trans2 if it has more stops than trans1</returns>
        public static bool operator < (Transport trans1, Transport trans2)
        {
            return trans1.Stops < trans2.Stops;
        }
    }
    
}
