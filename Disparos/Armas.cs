using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
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


        public virtual void Disparar()
        {
            Console.WriteLine($"El disparo tiene un poder de:{Power} y un rango de:{Range}");
        }
        //public virtual void Disparar(string armName, int shotPower, float shotRange)
        //{
        //    Console.WriteLine($"La pistola {armName},tiene un poder de {shotPower} y un rango de:{shotRange}");
        //}
    }
    public class Pistola : Armas 
    {
        public Pistola(string pistolName,int pistolPower, int pistolRange )
        {
            Name = pistolName;
            Power = pistolPower;
            Range = pistolRange;
        }
        public override void Disparar()
        {
            Console.WriteLine($"La pistola {Name},tiene un poder de {Power} y un alcance de {Range}");
        }
        //public override void Disparar(string armName, int shotPower, float shotRange)
        //{
        //    Console.WriteLine($"La pistola {armName},tiene un poder de {shotPower} y un alcance de {shotRange}");
        //}
    }
    public class Escopeta: Armas 
    {
        public Escopeta(string shotgunName,int shotgunPower,int shotgunRange)
        {
            Name = shotgunName;
            Power = shotgunPower;
            Range = shotgunRange;   
        }
        public override void Disparar()
        {
            Console.WriteLine($"La escopeta {Name} , tiene un poder de  {Power} y un alcance de {Range}");
        }
        //public override void Disparar(string armName,int shotPower, float shotRange)
        //{
        //    Console.WriteLine($"La escopeta {armName} , tiene un poder de  {shotPower} y un alcance de {shotRange}");
        //}

    }
    public class Rifles: Armas 
    {
        public Rifles(string rifleName,int riflePower,int rifleRange) 
        {
            Name = rifleName;
            Power = riflePower;
            Range = rifleRange;        
        }
        public override void Disparar()
        {
            Console.WriteLine($"El sniper {Name}, tiene un poder de {Power} y un alcance de {Range}");
        }
        //public override void Disparar(string armName, int shotPower, float shotRange)
        //{
        //    Console.WriteLine($"El sniper {armName}, tiene un poder de {shotPower} y un alcance de {shotRange}");
        //}
    }
}
