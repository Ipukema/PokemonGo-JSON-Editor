using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGo_JSON_Editor
{
        public class Userinfo
        {
            public string auth_service { get; set; }
            public string username { get; set; }
            public string password { get; set; }
            public string location { get; set; }
            public string gmapkey { get; set; }
            public int max_steps { get; set; }
            public string mode { get; set; }
            public string walk { get; set; }
            public bool debug { get; set; }
            public bool test { get; set; }
            public int initial_transfer { get; set; }
            public bool location_cache { get; set; }
            public string distance_unit { get; set; }
            public string item_filter { get; set; }
            public string evolve_all { get; set; }
        }
}
