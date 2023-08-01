public class Item {
    private static int _count = 0;

    public int Id { get; private set; }
    public string Name { get; set; } = "";
    public int Value { get; set; } = 0;

    public Item(string name, int value) {
        Id = _count++;
        Name = name;
        Value = value;
    }
}