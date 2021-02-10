using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItemScript : MonoBehaviour
{
    public GameObject item;
    private GameObject image;
    private bool s;
    
    // Start is called before the first frame update
    void Start()
    {
        s = false;
        item=
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "item")
        {
            if (s==true)
            {
                item.GetComponent<ItemScript>().UnEquip();
            }
            item = collision.gameObject;
            item.GetComponent<ItemScript>().Equip();
            GameObject.Find("itemImage").GetComponent<ItemImageScript>().setImage();
            s = true;
           
            
        }
    }
}
