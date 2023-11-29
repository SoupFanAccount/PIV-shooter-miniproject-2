using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 1;

    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        Debug.Log("Enemy Health: " + currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Enemy Died!");
        // Destroy the enemy when health reaches zero
        Destroy(gameObject);
    }
}