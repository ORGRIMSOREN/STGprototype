using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyborn : MonoBehaviour
{
    public GameObject enemyPrefab;
    void Start()
    {
        InvokeRepeating("Spawn", 2f, 0.5f);

    }

    void Spawn()
    {
        Vector3 spawnPosition = new Vector3(
            Random.Range(-1.5f,2),
            transform.position.y,
            transform.position.z);

        Instantiate(
            enemyPrefab,
            spawnPosition,
            transform.rotation);
    }
    void Update()
    {
        
    }
}
