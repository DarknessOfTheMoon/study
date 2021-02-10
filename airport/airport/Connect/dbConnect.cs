using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using airport.Model;

namespace airport.Connect
{
    public static class dbConnect
    {
        public static airportEntities db = new airportEntities();
    }
}
