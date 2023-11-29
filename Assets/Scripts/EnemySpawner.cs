using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform player;
    public float spawnInterval = 3.0f;
    public float enemySpeed = 3.0f;
    public float spawnDistance = 10.0f; // Distance from the player where enemies will spawn

    void Start()
    {
        // Invoke the SpawnEnemy method repeatedly based on the spawnInterval
        InvokeRepeating("SpawnEnemy", 0.0f, spawnInterval);
    }

    void SpawnEnemy()
    {
        // Calculate a random spawn position around the player within a circle
        Vector2 randomCirclePoint = Random.insideUnitCircle.normalized * spawnDistance;
        Vector3 spawnPosition = new Vector3(randomCirclePoint.x, 0.0f, randomCirclePoint.y) + player.position;

        // Instantiate an enemy at the calculated spawn position
        GameObject enemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);

        // Set the enemy's target to the player
        EnemyMovement enemyMovement = enemy.GetComponent<EnemyMovement>();
        if (enemyMovement != null)
        {
            enemyMovement.SetTarget(player);
            enemyMovement.SetSpeed(enemySpeed);
        }

        // Attach the EnemyHealth script to the enemy
        EnemyHealth enemyHealth = enemy.AddComponent<EnemyHealth>();
    }
}