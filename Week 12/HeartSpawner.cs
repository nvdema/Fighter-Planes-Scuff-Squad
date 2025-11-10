using UnityEngine;

public class HeartSpawner : MonoBehaviour
{
    public GameObject heartPrefab;
    public float spawnInterval = 5f;
    public float xRange = 8f;
    public float yRange = 4f;

    void Start()
    {
        InvokeRepeating("SpawnHeart", 2f, spawnInterval);
    }

    void SpawnHeart()
    {
        Vector3 randomPos = new Vector3(Random.Range(-xRange, xRange), Random.Range(-yRange, yRange), 0);
        Instantiate(heartPrefab, randomPos, Quaternion.identity);
    }
}