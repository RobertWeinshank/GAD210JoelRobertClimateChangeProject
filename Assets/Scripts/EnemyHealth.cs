using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [Header("Attributes")]
    [SerializeField] private int hitPoints = 2;
    
    public void TakeDamage(int damage)
    {
        hitPoints -= damage;

        if (hitPoints <= 0)
        {
            EnemySpawner.onEnemyDestroy.Invoke();
            Destroy(gameObject);
        }
    }
}
