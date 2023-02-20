/*
 * Gerard Lamoureux
 * SimpleZombieFactory
 * Assignment 5
 * Sets up the basic zombie class
 */

public class BasicZombie : Zombie
{
    protected override void ShowText()
    {
        textObject.text = "Base Zombie\nHealth: " + health + "\nDamage: " + damage;
    }
}
