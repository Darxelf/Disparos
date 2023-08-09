using Disparos.Disparos;
using Disparos.Enemies;


namespace Disparos.Main
{
    public partial class Main:Armas
    {
        int opcion = 0;
        Enemy foe = new Enemy("Juan Carlos");
        Armas pistol = new Pistola("Bersa", 50, 80);
        Armas shotgun = new Escopeta("Beretta", 150, 60);
        Armas sniper = new Rifles("Ak-5", 120, 150);

        public void GameStart() 
        {
            Console.WriteLine("Tienes 3 armas para elegir y disparar al enemigo que tienes al frente!");
            Console.WriteLine("Las opciones son: 1.Pistola 2.Escopeta 3.Sniper, cual eliges?");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    pistol.Disparar();
                    foe.Disparado(pistol.Power);//50 de poder del constructor
                    break;
                case 2:
                    shotgun.Disparar();
                    foe.Disparado(shotgun.Power);
                    break;
                case 3:
                    sniper.Disparar();
                    foe.Disparado(sniper.Power);
                    break;
                default:
                    Console.WriteLine("Opcion Incorrecta!");
                    break;
            }
        }

        
    }
}
 