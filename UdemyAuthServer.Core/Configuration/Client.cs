using System.Collections.Generic;

namespace UdemyAuthServer.Core.Configuration
{
    public class Client
    {
        public string Id { get; set; }
        public string Secret { get; set; }

        //wwww.myapi1.com    wwww.mayapi2.com - hansi apilere sorgu ata bilerse onlari veririk. payloadda vereciyik.
        public List<string> Audiences { get; set; } // bizim projecte bir nece API project ola biler ve client hansi Apilere request ata bilr onlari vereceyik.
    }
}
