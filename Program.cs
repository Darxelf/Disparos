// See https://aka.ms/new-console-template for more information
using Disparos.Disparos;
using Disparos.Enemies;

int opcion = 0;

Enemy foe = new Enemy("Juan Carlos");
Pistola pistol = new Pistola(50);
Escopeta shotgun = new Escopeta(150);
Rifles sniper = new Rifles(120);

//pistol.Name = "Bersa";
//shotgun.Name = "Beretta";
//sniper.Name = "Ak-5";



Console.WriteLine("Tienes 3 armas para elegir disparar al enemigo que tienes al frente.");
Console.WriteLine( "Las opciones son: 1.Pistola 2.Escopeta 3.Sniper, cual eliges?" );
opcion =Convert.ToInt32(Console.ReadLine());

switch (opcion)
{
    case 1:
        foe.Disparado(pistol.Power);//50 de poder del constructor
        foe.Disparar("Bersa",50,80);
        break;
    case 2:
        foe.Disparado(shotgun.Power);
        shotgun.Disparar("Beretta",150,60);
        break;
    case 3:
        foe.Disparado(sniper.Power);
        sniper.Disparar("Ak-5",120,150);
        break;
    default:
        Console.WriteLine("Opcion Incorrecta!");
        break;
}


