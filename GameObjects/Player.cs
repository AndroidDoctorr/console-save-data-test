public enum ArmorType { None, Leather, Chain, Plate }
public class Player {
    public int Health { get; set; } = 100;
    public string Location { get; set; } = "The Shire";
    public int XP { get; set; } = 0;
    public ArmorType Armor { get; set; } = ArmorType.None;
    public List<Item> Inventory { get; } = new List<Item>();
    public void AddItem(Item item) {
        Inventory.Add(item);
    }

    public override string ToString()
    {
        string inventory = "";
        foreach (Item item in Inventory) {
            inventory += $"{item.Id},";
        }

        string invString = String.Join(",", Inventory.Select(item => item.Id).ToArray());

        return $"{Health};{Location};{XP};{(int) Armor};{invString}";
    }
}