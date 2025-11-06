using UnityEngine;
using System.Collections; // Required for Coroutines

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // Assign your enemy Prefab in the Inspector
    public float spawnIntervalMin = 2f; // Minimum time between spawns
    public float spawnIntervalMax = 5f; // Maximum time between spawns
    public int maxEnemies = 10; // Optional: Limit the number of active enemies

    private int currentEnemies = 0;

    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        while (true) // Loop indefinitely for continuous spawning
        {
            // Optional: Check if max enemies limit is reached
            if (currentEnemies < maxEnemies)
            {
                float randomInterval = Random.Range(spawnIntervalMin, spawnIntervalMax);
                yield return new WaitForSeconds(randomInterval);

                Instantiate(enemyPrefab, transform.position, Quaternion.identity);
                currentEnemies++;
            }
            else
            {
                yield return null; // Wait one frame if max enemies reached
            }
        }
    }

    // Call this method when an enemy is destroyed to decrement the count
    public void EnemyDied()
    {
        currentEnemies--;
    }
}
