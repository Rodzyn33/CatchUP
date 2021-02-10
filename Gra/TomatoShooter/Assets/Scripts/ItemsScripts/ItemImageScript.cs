using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemImageScript : MonoBehaviour
{
    public GameObject gracz;
    // Start is called before the first frame update
    void Start()
    {
       gracz = GameObject.Find("Player");
}

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setImage()
    {
        GameObject item = gracz.GetComponent<PlayerItemScript>().item;
        this.gameObject.GetComponent<Image>().sprite = item.GetComponent<SpriteRenderer>().sprite;
    }

}
