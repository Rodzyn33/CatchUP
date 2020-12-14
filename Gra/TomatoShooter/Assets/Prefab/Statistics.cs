using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statistics : MonoBehaviour
{
    public float health;
    public float movementSpeed;
    public float attackDamage;
    public float fireRate;
    public float critic;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void takeDamage(float damage)
    {
        health = health - damage;
        Debug.Log(health);
    }
   
}
