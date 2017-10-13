using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    public class Connection
    {
        public string station1;
        public string station2;
        public int tarief;

        /// <summary>
        /// A connection always connects two train stations and has one price.
        /// </summary>
        /// <param name="s1">station1</param>
        /// <param name="s2">station2</param>
        /// <param name="t">tarief</param>
        public Connection(string s1, string s2, int t)
        {
            station1 = s1;
            station2 = s2;
            tarief = t;
        }
    }

    public class Route
    {
        public List<Connection> route = new List<Connection>();

        public Route(Connection firstConnection)
        {
            route.Add(firstConnection);
        }

        public bool Contains(string station)
        {
            foreach (Connection c in route)
            {
                if (c.station1 == station || c.station2 == station)
                {
                    return true;
                }
            }
            return false;
        }
    }

    public static class TarievenGraaf
    {
        static List<Connection> allConnections = new List<Connection>();
        
        static TarievenGraaf()
        {
            AddConnection("Utrecht Centraal", "Geldermalsen", 26);
            AddConnection("Utrecht Centraal", "Hilversum", 18);
            AddConnection("Utrecht Centraal", "Gouda", 32);
            AddConnection("Utrecht Centraal", "Duivendrecht", 31);
            AddConnection("Hilversum", "Weesp", 15);
            AddConnection("Weesp", "Duivendrecht", 3);
            AddConnection("Duivendrecht", "Gouda", 54);
        }
        
        /// <summary>
        /// Add a new connection. No duplicates.
        /// </summary>
        /// <param name="st1">station1</param>
        /// <param name="st2">station2</param>
        /// <param name="tarief">price</param>
        public static void AddConnection(string st1, string st2, int tarief) // TODO: remove connection if station is on an existing one
        {
            foreach (Connection c in allConnections) // Check if the connction already exists
            {
                if (GetConnectionName(c.station1, c.station2) == GetConnectionName(st1, st2))
                {
                    return;
                }
            }

            allConnections.Add(new Connection(st1, st2, tarief));
        }

        static string GetConnectionName(string station1, string station2)
        {
            if (String.Compare(station1, station2) < 0) // We put the stations in alphabetic order to prevent double entries
            {
                return station1 + station2;
            }
            else
            {
                return station2 + station1;
            }
        }

        public static string[] getStations()
        {
            List<string> res = new List<string>();
            foreach (Connection c in allConnections)
            {
                if (!res.Contains(c.station1))
                {
                    res.Add(c.station1);
                }
                if (!res.Contains(c.station2))
                {
                    res.Add(c.station2);
                }
            }

            return res.ToArray();
        }

        public static int getTariefeenheden(string from, string to)
        {
            if (from == to) { return 0; }

            int price;

            List<Route> allPaths = new List<Route>();
            Route lowestPricePath;

            foreach (Connection c in allConnections)
            {
                if (from == c.station1 || from == c.station2)
                {
                    Route temp = new Route(c);
                    allPaths.Add(temp);
                }
            }

            while (allPaths.Count != 0)
            {
                for (int i = 0; i < allPaths.Count; i++) // if we made it on a route, we remove it from the list
                {
                    if (allPaths[i].Contains(to))
                    {
                        //if (lowestPricePath.Contains(to))
                        {

                        }
                    }
                }
            }


            return 0;
        }
    }
}
