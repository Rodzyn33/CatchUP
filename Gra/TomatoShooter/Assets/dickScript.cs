using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dickScript : MonoBehaviour
    
{
    private GameObject target;
    private float Speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player");
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

    }
}
