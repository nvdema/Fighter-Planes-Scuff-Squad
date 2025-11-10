using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public float spawnInterval = 3f;

    private float xRange = 8f;
    private float yRange = 4f;

    private void Start()
    {
        InvokeRepeating("SpawnCoin", 1f, spawnInterval);
    }
    void SpawnCoin()
    {
        Vector3 randomPos = new Vector3(Random.Range(-xRange, xRange), Random.Range(-yRange, yRange), 0);
        Instantiate(coinPrefab, randomPos, Quaternion.identity);
    }
}
