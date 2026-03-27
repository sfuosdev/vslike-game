using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // Assign your enemy prefab in the inspector
    public float spawnInterval = 2f; // Time between each spawn
    public Transform playerTransform; // Assign the player's transform in the inspector
    private Transform childTransform; // To cache the child's transform
    public float spawnRadius = 5f; // Radius around the player where enemies will spawn
    private float timer = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        childTransform = playerTransform.Find("sprite_player");
    }
    
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > spawnInterval)
        {
            SpawnEnemy();
            timer = 0;
        }
    }
    
    void SpawnEnemy()
    {
        if (childTransform != null)
        {
            float angle = Random.Range(0f, 360f) * Mathf.Deg2Rad; // Convert to radians

            // Calculate the spawn position based on the angle and radius, using the player's current position
            Vector3 pos = childTransform.position;
            Vector2 spawnPosition = new Vector2(
                pos.x + spawnRadius * Mathf.Cos(angle),
                pos.y + spawnRadius * Mathf.Sin(angle));

            // Instantiate the enemy prefab at the spawn position
            Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
