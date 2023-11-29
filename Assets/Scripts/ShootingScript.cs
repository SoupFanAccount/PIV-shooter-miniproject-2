using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    public Transform muzzleTransform;
    public GameObject projectilePrefab;
    public float shotCooldown = 0.5f;
    public float projectileForce = 10f;

    private float lastShotTime;

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && CanShoot())
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Check if the muzzleTransform is assigned and the projectilePrefab is assigned
        if (muzzleTransform != null && projectilePrefab != null)
        {
            // Instantiate a projectile at the muzzle position with the muzzle's rotation
            GameObject projectile = Instantiate(projectilePrefab, muzzleTransform.position, muzzleTransform.rotation);

            // Check if the projectile has a Rigidbody component
            Rigidbody projectileRb = projectile.GetComponent<Rigidbody>();
            if (projectileRb == null)
            {
                // Add a Rigidbody component if it doesn't exist
                projectileRb = projectile.AddComponent<Rigidbody>();
            }

            // Apply force to the projectile in the forward direction of the muzzle
            projectileRb.AddForce(muzzleTransform.forward * projectileForce, ForceMode.Impulse);

            // Update the last shot time
            lastShotTime = Time.time;
        }
    }

    bool CanShoot()
    {
        // Check if enough time has passed since the last shot
        return Time.time - lastShotTime > shotCooldown;
    }

    public int damage = 1;

    void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object has an EnemyHealth script
        EnemyHealth enemyHealth = collision.gameObject.GetComponent<EnemyHealth>();

        if (enemyHealth != null)
        {
            // If the object has an EnemyHealth script, apply damage
            enemyHealth.TakeDamage(damage);
        }

        // Destroy the bullet on collision
        Destroy(gameObject);
    }
}