using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bossScript : MonoBehaviour
{
    public int health;
    public Slider healthbar;
    public GameObject BossBullet;
    public GameObject HPboost;

    private GameObject target;
    public float Speed;
    public GameObject boss1;

    bool obrot = true;
    float fireRate;
    float nextFire;

    // Start is called before the first frame update
    void Start()
    {
        fireRate = 1f;
        nextFire = Time.time;
        target = GameObject.Find("Player");
    }

    // Update is called once per frame
    private void Update()
    {

        CheckBossFire();
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

        healthbar.value = health;
        if (target.GetComponent<Rigidbody2D>().transform.localPosition.x < gameObject.GetComponent<Rigidbody2D>().transform.localPosition.x && obrot)
        {
            Flip();
        }
        else if (target.GetComponent<Rigidbody2D>().transform.localPosition.x > gameObject.GetComponent<Rigidbody2D>().transform.localPosition.x && !obrot)
        {
            Flip();
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("bullet"))
        {
            Destroy(col.gameObject);
            health -= 1;

            if (health <= 0)
            {
                Destroy(gameObject);
                scoreScript.scoreValue += scoreScript.AdderBoss;
                Instantiate(HPboost, transform.position, Quaternion.identity);
            }
        }
    }

    void CheckBossFire()
    {
        if (Time.time > nextFire)
        {
            Instantiate(BossBullet, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
    }
    void Flip()
    {
        obrot = !obrot;
        transform.Rotate(0f, 180f, 0f);
    }
}