using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
    
         public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;   
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria; 
           
        }   


        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string Imei   { get; set; }
        private int Memoria { get; set; }



        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);


        public void ExibirDados()
        {
            Console.WriteLine($"modelo: {Modelo} \n imei:{Imei} \n memoria:{Memoria}");
        }
    }
}