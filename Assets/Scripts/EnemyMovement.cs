using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Transform target;
    private float speed = 3.0f;
    public GameObject enemy;

    void Update()
    {
        // Move towards the target (player)
        if (target != null)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            transform.Translate(direction * speed * Time.deltaTime);
        }
    }

    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }

    public void SetSpeed(float newSpeed)
    {
        speed = newSpeed;
    }
}