/*
 * Gerard Lamoureux
 * DogZombie
 * Assignment 5
 * Sets up the Dog zombie class
 */
using UnityEngine;

public class DogZombie : Zombie
{
    protected bool isJumping = true;
    [SerializeField] float jumpSpeed;

    protected override void ShowText()
    {
        textObject.text = "Zombie Dog\nHealth: " + health + "\nDamage: " + damage;
    }

    protected override void Move()
    {
        if (isJumping)
        {
            rb.velocity = new Vector2(speed, jumpSpeed);
            isJumping = false;
        }
        else
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isJumping = true;
    }
}
