using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chestScript : MonoBehaviour
{
    private SpriteRenderer spriteRend;
    [SerializeField]
    private Sprite openChest;
    private bool active;
    private Vector2 position;
    private GameObject wypadl;
    public GameObject zawartość;
    [SerializeField]
    public bool otwarto;
    // Start is called before the first frame update
    void Start()
    {
        spriteRend = gameObject.GetComponent<SpriteRenderer>();
        position =new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (active == true && Input.GetKeyDown(KeyCode.E)&&!otwarto){
            spriteRend.sprite = openChest;
            wypadl=Instantiate(zawartość, position, Quaternion.identity);
            //wypadl.GetComponent<Renderer>().sortingOrder = 4990;
            wypadl.transform.Translate(0f,-0.5f,0f) ;
            otwarto = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
            active = true;
   
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.name=="Player")
        {
            active = false;
        }
    }
}
