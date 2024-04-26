using System;
using System;
using BattleMage;

Unit player = new Unit(100, 20, 12, "Player");
Unit enemy = new Unit(75, 10, 7, "Enemy Mage");
Random random = new Random();

while (!player.isDead && !enemy.isDead)
{
    Console.WriteLine(player.UnitName + " HP = " + player.Hp + ". " + enemy.UnitName + " HP = " + enemy.Hp);
    Console.WriteLine("Player turn! What will you do?");
    string choice = Console.ReadLine();

    if (choice == "a")
        player.Attack(enemy);
    else
        player.Heal();

    if (player.isDead || enemy.isDead) break;

    Console.WriteLine(player.UnitName + " HP = " + player.Hp + ". " + enemy.UnitName + " HP = " + enemy.Hp);

    Console.WriteLine("Enemy turn!");

    int rand = random.Next(0, 2);

    if (rand == 0)
        enemy.Attack(player);
    else
        enemy.Heal();
}