using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemsSpawner : MonoBehaviour
{
    
    public GameObject HP;

    float randX;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(HP, whereToSpawn, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(3.2f, -6.85f);
            whereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate(HP, whereToSpawn, Quaternion.identity);
        }
    }
}
