public enum WeaponType { Melee, Ranged, Magic, Other }
public class Weapon : Item {
    public int AttackDamage { get; set; } = 0;
    public WeaponType Type { get; set; } = WeaponType.Other;
    public Weapon(string name, int value, int attackDamage, WeaponType type) : base(name, value) {
        AttackDamage = attackDamage;
        Type = type;
    }
}