// See https://aka.ms/new-console-template for more information
using Disparos.Disparos;
using Disparos.Enemies;

Enemy foe = new Enemy("Juan Carlos");

Armas pistol = new Pistola();
Armas shotgun = new Escopeta();
Armas sniper = new Rifles();

pistol.Name = "Bersa";
pistol.Power = 50;
pistol.Range = 80;
pistol.Disparar();

shotgun.Name = "Beretta";
shotgun.Power = 150;
shotgun.Range = 60; 
shotgun.Disparar();

sniper.Name = "Ak 5";
sniper.Power = 120;
sniper.Range = 150;
sniper.Disparar();

foe.Disparado(pistol.Power);