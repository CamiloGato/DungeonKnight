using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [Header("Prefabs")]
    public Transform enemyPrefab;
    
    [Header("Spawn Settings")]
    public float spawnDelay = 1f;
    public float spawnInterval = 1f;
    public Transform[] spawnPoints;

    private void Start()
    {
        foreach (Transform spawnPoint in spawnPoints)
        {
            Instantiate(enemyPrefab, spawnPoint);
        }
    }
}
