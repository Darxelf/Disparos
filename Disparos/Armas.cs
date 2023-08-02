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

        //public Armas()
        //{
            
        //}

        public virtual void Disparar()
        {
            Console.WriteLine($"El disparo tiene un poder de:{Power} y un rango de:{Range}");
        }
        public virtual void Disparar(string armName, int shotPower, float shotRange)
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
        public override void Disparar(string armName, int shotPower, float shotRange)
        {
            Console.WriteLine($"La pistola {armName},tiene un poder de {shotPower} y un alcance de {shotRange}");
        }
    }
    public class Escopeta: Armas 
    {
        public Escopeta(int escopetaPower)
        {
            Power = escopetaPower;
        }
        public override void Disparar(string armName,int shotPower, float shotRange)
        {
            Console.WriteLine($"La escopeta {armName} , tiene un poder de  {shotPower} y un alcance de {shotRange}");
        }

    }
    public class Rifles: Armas 
    {
        public Rifles(int riflePower) 
        {
            Power = riflePower;    
        }
        public override void Disparar(string armName, int shotPower, float shotRange)
        {
            Console.WriteLine($"El sniper {armName}, tiene un poder de {shotPower} y un alcance de {shotRange}");
        }
    }
}
