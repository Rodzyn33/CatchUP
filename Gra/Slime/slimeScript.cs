using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slimeScript : MonoBehaviour
{
    public GameObject target;
    private float Speed;
    private float hp;
    private float ad;
    // Start is called before the first frame update
    void Start()
    {
        Speed = gameObject.GetComponent<Statistics>().movementSpeed;
        hp= gameObject.GetComponent<Statistics>().health;
        ad = gameObject.GetComponent<Statistics>().attackDamage;
        
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
            gameObject.GetComponent<Rigidbody2D>().velocity = gameObject.GetComponent<Rigidbody2D>().velocity + Vector2.up* Speed;
        }
    }
    private void FixedUpdate()
    {

        Speed = gameObject.GetComponent<Statistics>().movementSpeed;
        hp = gameObject.GetComponent<Statistics>().health;
        ad = gameObject.GetComponent<Statistics>().attackDamage;
        if (hp <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
