using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectablesScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col1)
    {
        if(col1.gameObject.tag.Equals("Player"))
        {
            Destroy(gameObject);
            GetComponent<hpScript>().health += 1;
        }
    }
}
