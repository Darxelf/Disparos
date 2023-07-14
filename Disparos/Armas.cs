using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disparos.Disparos
{
   public  class Armas
    {
        public string Name { get; set; }
      public  int Power { get; set; }
      public  float Range { get; set;}
      public  int Speed { get; set; } 
        public virtual void Disparar() 
        {
            Console.WriteLine($"El disparo tiene un poder de:{Power} y un rango de:{Range}");
        }
    }
    public class Pistola : Armas 
    {
        public override void Disparar()
        {
            Console.WriteLine($"La pistola {Name},tiene un poder de {Power} y un alcance de {Range}");
        }
    }
    public class Escopeta: Armas 
    {
        public override void Disparar()
        {
            Console.WriteLine($"La escopeta {Name} , tiene un poder de  {Power} y un alcance de {Range}"  );
        }

    }
    public class Rifles: Armas 
    {
        public override void Disparar()
        {
            Console.WriteLine($"El sniper {Name}, tiene un poder de {Power} y un alcance de {Range}"  );
        }
    }
}
