using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disparos.Disparos
{
    public class Armas
    {
        public string Name { get; set; }
        public int Power { get; set; }
        public float Range { get; set; }
        public int Speed { get; set; }

        //public Armas(int shotPower) 
        //{
        //    Power = shotPower;
        //}

        public virtual void Disparar()
        {
            Console.WriteLine($"El disparo tiene un poder de:{Power} y un rango de:{Range}");
        }
        public virtual void Disparar(string armName,int shotPower, float shotRange) 
        {
            Console.WriteLine($"La pistola {armName},tiene un poder de {shotPower} y un rango de:{shotRange}");
        }
    }
    public class Pistola : Armas 
    {
        public Pistola(int pistolPower)
        {
            Power = pistolPower;
        }
        //public override void Disparar()
        //{
        //  Console.WriteLine($"La pistola {Name},tiene un poder de {Power} y un alcance de {Range}");
        //}
    }
    public class Escopeta: Armas 
    {
        public Escopeta(int escopetaPower) 
        {
            Power = escopetaPower;
        }
        public override void Disparar()
        {
            Console.WriteLine($"La escopeta {Name} , tiene un poder de  {Power} y un alcance de {Range}"  );
        }

    }
    public class Rifles: Armas 
    {
        public Rifles(int riflePower) 
        {
            Power = riflePower;    
        }
        public override void Disparar()
        {
            Console.WriteLine($"El sniper {Name}, tiene un poder de {Power} y un alcance de {Range}"  );
        }
    }
}
