/*
 * Gerard Lamoureux
 * Boss Zombie
 * Assignment 5
 * Sets Up the Boss Zombie Class
 */

public class BossZombie : Zombie
{

    protected override void ShowText()
    {
        textObject.text = "Boss Zombie\nHealth: " + health + "\nDamage: " + damage;
    }
}
