// Adventure game, keeps track of a Player object, which has an inventory
// Saves and loads periodically

Item potion = new Item("Health Potion", 250);
Weapon sword = new Weapon("Lvl 1 Sword", 250, 10, WeaponType.Melee);

Player player = new Player();
player.Health = 80;
player.Armor = ArmorType.Leather;
player.XP = 1500;
player.AddItem(potion);
player.AddItem(sword);

PlayerData.SavePlayer(player);

Player player1 = PlayerData.LoadPlayer();

Console.WriteLine(player.ToString());
Console.WriteLine(player1.ToString());
