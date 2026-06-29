using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Rigidbody2D rb;

    [Header("Attributes")]
    [SerializeField] private float moveSpeed = 2f;

    //point we want to move to
    private Transform target;
    private int pathIndex = 0;

    private void Start()
    {
        target = LevelManager.main.path[pathIndex];
    }

    private void Update()
    {
        //If the enemy's position is on the targeted path location, increase pathIndex 
        if (Vector2.Distance(target.position, transform.position) <= 0.1f)
        {
            pathIndex++;
            

            //If the enemy makes it to the end of the path, destroy the enemy; else set target's location equal to the next target on the path
            if (pathIndex == LevelManager.main.path.Length)
            {
                EnemySpawner.onEnemyDestroy.Invoke();
                Destroy(gameObject);
                return;
            }
            else
            {
                target = LevelManager.main.path[pathIndex];
            }
        }
    }

    private void FixedUpdate()
    {
        //Move the enemy towards the target
        Vector2 direction = (target.position - transform.position).normalized;

        rb.linearVelocity = direction * moveSpeed;
    }
}
