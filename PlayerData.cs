public class PlayerData {
    private static string saveFilePath = "./playerData.sav";


    public static void SavePlayer(Player player) {
        string playerString = player.ToString();

        using (StreamWriter writer = new StreamWriter(saveFilePath))
        {
            writer.WriteLine(playerString);
        }
    }

    public static Player LoadPlayer() {
        string playerString = File.ReadAllText(saveFilePath);
        Console.WriteLine(playerString);
        
        string[] dataPieces = playerString.Split('|');
        string playerStatString = dataPieces[0];
        string inventoryString = (dataPieces.Count() > 1) ? dataPieces[1] : "(no items)";

        string[] playerStats = playerStatString.Split(';');

        Player player = new Player();
        player.Health = Convert.ToInt32(playerStats[0]);
        player.Location = playerStats[1];
        player.XP = Convert.ToInt32(playerStats[2]);
        player.Armor = (ArmorType) Convert.ToInt32(playerStats[3]);

        // TODO: Load inventory from inventory string!

        return player;
    }
}