/*
 * Gerard Lamoureux
 * Zombie
 * Assignment 5
 * The base Zombie Class to be used by specific zombie types
 */

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Zombie : MonoBehaviour
{

    [SerializeField] protected float maxXValueToMove;
    [SerializeField] protected int health;
    [SerializeField] protected int damage;
    [SerializeField] protected float speed;
    [SerializeField] protected TextMeshProUGUI textObject;
    protected Rigidbody2D rb;

    protected Coroutine attackRoutine;

    protected virtual void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    protected virtual void FixedUpdate()
    {
        Move();
        ShowText();
        StartAttack();
    }

    protected virtual void ShowText()
    {
        textObject.text = "Zombie\nHealth: " + health + "\nDamage: " + damage;
    }

    protected virtual void Move()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }

    protected virtual void StartAttack()
    {
        if (transform.position.x > maxXValueToMove && attackRoutine == null && !PlayerController.thisPlayerController.GameOver)
        {
            attackRoutine = StartCoroutine(Attack());
        }
    }

    protected virtual IEnumerator Attack()
    {
        PlayerController.thisPlayerController.TakeDamage(damage);
        yield return new WaitForSeconds(1);
        attackRoutine = null;
    }

    public virtual void SetSpeed(float speed)
    {
        this.speed = speed;
    }

    private void OnMouseDown()
    {
        TakeDamage(PlayerController.thisPlayerController.damage);
    }

    public virtual void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
            Die();
    }

    public virtual void Die()
    {
        Destroy(gameObject);
    }
}
