using Disparos.Disparos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Disparos.Enemies
{

    internal class Enemy:Armas
    {
        string Name;
        int Hp = 300;
        int HeadHp { get; set; }
        bool Shot = true;
     
        public Enemy(string enemyName) 
        {
            Name = enemyName;
           
        }

        public void Disparado(int shotPower) 
        {

            if (Shot == true )
            {
                Hp = Hp - shotPower;
                Console.WriteLine($"La vida del {Name} es: {Hp}");
            }
            else if (Shot == true && Hp == shotPower) 
            {
               Hp = Hp -shotPower;
                Console.WriteLine("Enemy Killed!");
            }
            
        }

    }
}
