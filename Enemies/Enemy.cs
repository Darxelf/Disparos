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
        int body;
        int accuracy;
        bool Shot = false;
        //Enemy foe;
        Random shotConfirm = new Random();
        Random bodyHurtBox = new Random();
        public Enemy(string enemyName) 
        {
            Name = enemyName;
           
        }

        public void Disparado(int shotPower) 
        {
            accuracy = shotConfirm.Next(1,2);
            if (accuracy == 1)
            {
                Shot = true;
                body = bodyHurtBox.Next(1, 3);
                if (Shot == true && body == 1)
                {
                    //Hp = 0;
                    Console.WriteLine("HeadShot!!");

                }
                else if (Shot == true && body > 1)
                {
                    Hp = Hp - shotPower;
                    Console.WriteLine($"La vida del {Name} es: {Hp}");
                }
            }
            else 
            {
                Console.WriteLine("Has Fallado el disparo!");

            }

        }
        

    }
}
