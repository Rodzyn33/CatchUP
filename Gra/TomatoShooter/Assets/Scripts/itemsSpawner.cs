using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemsSpawner : MonoBehaviour
{
    
    public GameObject HP;

    float randX;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 3.2f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(3.2f, 3.2f);
            whereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate(HP, whereToSpawn, Quaternion.identity);
        }
    }
}
