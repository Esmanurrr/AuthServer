using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthServer.Core.Configuration
{
    public class Client//it can be web app or mobile app, just for request to authserver
    {
        public string Id { get; set; } //username
        public string Secret { get; set; } //password

        //ex: www.myapi1.com www.myapi2.com can access
        public List<string> Audiences { get; set; }//which api can access?
    }
}
