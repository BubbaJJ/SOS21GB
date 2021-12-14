using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vecka11
{
    class Player
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public int? height_feet { get; set; }
        public int? height_inches { get; set; }
        public string last_name { get; set; }
        public string position { get; set; }
        public Team team { get; set; }
        public int? weight_pounds { get; set; }
    }
}