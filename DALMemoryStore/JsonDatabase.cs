using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALMemoryStore
{
    public class JsonDatabase
    {

        public class Rootobject
        {
            public string Servername { get; set; }
            public string ConnectionString { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string Database { get; set; }
        }

    }
}
