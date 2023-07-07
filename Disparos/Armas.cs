using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disparos.Disparos
{
   public  class Armas
    {
        int power { get; set; }
        float range { get; set;}
        int speed { get; set; } 
        public virtual void disparar() 
        {
            Console.WriteLine($"El disparo tiene un poder de:{power} y un rango de:{range}");
        }
    }
    public class Pistola : Armas 
    {
        public override void disparar()
        {
            Console.WriteLine("");
        }
    }
}
