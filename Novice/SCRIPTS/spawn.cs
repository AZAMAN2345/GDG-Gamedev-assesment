using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform playerTransform;
    public float spawnInterval = 3f;
    private float nextSpawnTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (playerTransform == null)
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            if (player != null)
            {
                playerTransform = player.transform;

            }
            else
            {
                Debug.LogWarning("Player Transform is not assigned and Player with tag 'Player' not found in the scene.");
            }

        }
        nextSpawnTime = Time.time + spawnInterval;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnEnemyOnPlayer();
            nextSpawnTime = Time.time + spawnInterval;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnEnemyOnPlayer();
        }
    }
    void SpawnEnemyOnPlayer()
    {
        if (playerTransform != null && enemyPrefab != null)
        {
            Instantiate(enemyPrefab, playerTransform.position, Quaternion.identity);
            Debug.Log("Enemy Spawned at Player Position");
        }
        else
        {
            Debug.LogWarning("player Transform or Enemy Prefab not Assigned.");
        }
    }
}
