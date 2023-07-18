// See https://aka.ms/new-console-template for more information
using Disparos.Disparos;
using Disparos.Enemies;

int opcion = 0;

Enemy foe = new Enemy("Juan Carlos");

Armas pistol = new Pistola();
Armas shotgun = new Escopeta();
Armas sniper = new Rifles();

pistol.Name = "Bersa";
pistol.Power = 50;
pistol.Range = 80;

shotgun.Name = "Beretta";
shotgun.Power = 150;
shotgun.Range = 60; 

sniper.Name = "Ak-5";
sniper.Power = 120;
sniper.Range = 150;


Console.WriteLine("Tienes 3 armas para elegir disparar al enemigo que tienes al frente.");
Console.WriteLine( "Las opciones son: 1.Pistola 2.Escopeta 3.Sniper, cual eliges?" );
opcion =Convert.ToInt32(Console.ReadLine());

switch (opcion)
{
    case 1:
        foe.Disparado(pistol.Power);
        pistol.Disparar();
        break;
    case 2:
        foe.Disparado(shotgun.Power);
        shotgun.Disparar();
        break;
    case 3:
        foe.Disparado(sniper.Power);
        sniper.Disparar();
        break;
    default:
        Console.WriteLine("Opcion Incorrecta!");
        break;
}


