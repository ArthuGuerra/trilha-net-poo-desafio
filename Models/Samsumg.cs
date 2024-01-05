using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPOO.Models
{
    public class Samsung : Smartphone
    {

        public Samsung (string numero,string modelo, string imei, int memoria) : base(numero,modelo,imei,memoria)
        {


        }

         public override void InstalarAplicativo(string nomeApp)
         {
            Console.WriteLine($"instalando o aplicativo {nomeApp} no Samsumg Galaxy S24-PRO ");
         }
        
    }
}