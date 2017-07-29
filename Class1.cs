using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{

    public class BusPark
    {
        public List< Bus> avtobuslar { get; set; }
        public List<RoutePath> yol { get; set; }
    }
    public class Bus
    {
        public int number { get; set; }
        public Driver surucu { get; set; }
        
    }

    public class RoutePath
    {
        public string marshrut { get; set; }
        public int kilometraj { get; set; }
    }

    public class Driver
    {
        public string ad { get; set; }
    }
}
