using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slimeScript : MonoBehaviour
{
    public GameObject particles;
    public GameObject boss1;
    private GameObject target;
    private float Speed;
    private float hp;
    private float ad;
    Vector2 whereToSpawnBoss;
    bool obrot = true;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player");
        Speed = gameObject.GetComponent<Statistics>().movementSpeed;
        hp = gameObject.GetComponent<Statistics>().health;
        ad = gameObject.GetComponent<Statistics>().attackDamage;
    }
    private void Awake()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        if (target.GetComponent<Rigidbody2D>().transform.localPosition.x < gameObject.GetComponent<Rigidbody2D>().transform.localPosition.x)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.left * Speed;
        }
        else if (target.GetComponent<Rigidbody2D>().transform.localPosition.x > gameObject.GetComponent<Rigidbody2D>().transform.localPosition.x)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.right * Speed;
        }
        if (target.GetComponent<Rigidbody2D>().transform.localPosition.y < gameObject.GetComponent<Rigidbody2D>().transform.localPosition.y)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = gameObject.GetComponent<Rigidbody2D>().velocity + Vector2.down * Speed;
        }
        else if (target.GetComponent<Rigidbody2D>().transform.localPosition.y > gameObject.GetComponent<Rigidbody2D>().transform.localPosition.y)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = gameObject.GetComponent<Rigidbody2D>().velocity + Vector2.up * Speed;
        }

        if (target.GetComponent<Rigidbody2D>().transform.localPosition.x < gameObject.GetComponent<Rigidbody2D>().transform.localPosition.x && obrot)
        {
            Flip();
        }
        else if (target.GetComponent<Rigidbody2D>().transform.localPosition.x > gameObject.GetComponent<Rigidbody2D>().transform.localPosition.x && !obrot)
        {
            Flip();
        }
        
    }
    private void FixedUpdate()
    {
        Speed = gameObject.GetComponent<Statistics>().movementSpeed;
        hp = gameObject.GetComponent<Statistics>().health;
        ad = gameObject.GetComponent<Statistics>().attackDamage;
        if (hp <= 0)
        {
            Instantiate(particles, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
            scoreScript.scoreValue += scoreScript.Adder;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("spikes"))
        {
            Destroy(gameObject);
        }
    }
    void Flip()
    {
        obrot = !obrot;
        transform.Rotate(0f, 180f, 0f);
    }
}
