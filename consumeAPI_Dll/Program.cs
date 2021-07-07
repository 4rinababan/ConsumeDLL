using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using API;

namespace consumeAPI_Dll
{
    class Program
    {
        static void Main(string[] args)
        {
             void consume ()
            {
                API.API api = new API.API();
                try
                {
                    var response = api.getJson("http://worldclockapi.com/api/json/est/now", "");
                    Console.WriteLine(response);
                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    Console.ReadKey();
                }
            }
            consume();
        }
    }
}
