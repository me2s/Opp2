using System;

namespace _2Lab
{
    /// <summary>
    /// Class that describes data of a transport vehicle
    /// </summary>
    class Transport
    {
        public int Number { get; set; } //route number
        public string Route { get; set; } //route
        public int Distance { get; set; } // route distance
        public int Stops { get; set; } // number of stops in a route

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
            line = string.Format("{0,-3}  | {1,-30}    | {2,4}    |{3,5}", Number, Route,
                                 Distance, Stops);
            return line;
        }

        /// <summary>
        /// Number of stops and route name comparison method >
        /// </summary>
        /// <param name="trans1">Vehicle 1 stops</param>
        /// <param name="trans2">Vehicle 2 stops</param>
        /// <returns>True if trans1 has more stops than trans2 or if stop count is the same
        /// compares route names and returns false if trans1 higher alphabetically</returns>
        public static bool operator >(Transport trans1, Transport trans2)
        {
            int temp = String.Compare(trans1.Route, trans2.Route,
                       StringComparison.CurrentCulture);
            return trans1.Stops > trans2.Stops || (trans1.Stops == trans2.Stops &&
                   temp < 0);
        }

        /// <summary>
        /// Number of stops and route name comparison method <
        /// </summary>
        /// <param name="trans1">Vehicle 1 stops</param>
        /// <param name="trans2">Vehicle 2 stops</param>
        /// <returns>True if trans1 has less stops than trans2 or if stop count is the same
        /// compares route names and returns true if trans1 lower alphabetically</returns>
        public static bool operator <(Transport trans1, Transport trans2)
        {
            int temp = String.Compare(trans1.Route, trans2.Route,
           StringComparison.CurrentCulture);
            return trans1.Stops < trans2.Stops || (trans1.Stops == trans2.Stops &&
                   temp > 0);
        }
    }
}
