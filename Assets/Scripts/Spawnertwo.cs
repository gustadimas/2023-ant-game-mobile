using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnertwo : MonoBehaviour
{
    public float minX, maxX, spawnTime; 
    float nextSpawn;
    [SerializeField] private GameObject[] enemies;
    
    void Start()
    {
        nextSpawn = Time.time;
    }

    void Update()
    {
        Spawn();
    }

    private void Spawn()
    {
        if (Time.time > nextSpawn)
        {
            Vector2 position = new Vector2(Random.Range(minX, maxX), transform.position.y);
            Instantiate(enemies[Random.Range(0, enemies.Length)], new Vector2(position.x, position.y), Quaternion.Euler(0f,0f, 180f));
            nextSpawn = Time.time + spawnTime;
        }
    }
}
