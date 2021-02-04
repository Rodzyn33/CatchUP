using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mustacheScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Equip()
    {
        GameObject.Find("Player").GetComponent<PlayerScript>().moveSpeed = GameObject.Find("Player").GetComponent<PlayerScript>().moveSpeed+5f;
    }

    void UnEquip()
    {
        GameObject.Find("Player").GetComponent<PlayerScript>().moveSpeed = GameObject.Find("Player").GetComponent<PlayerScript>().moveSpeed - 5f;
    }
}
