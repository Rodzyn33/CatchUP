﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    public Animator animator;
    private Vector2 moveDirection;
    bool obrot = true;

    public GameObject bulletPrefab;
    public float fireDelay;
    public float bulletSpeed;
    private float lastFire;
    

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
       
        if(GetComponent<hpScript>().health <= 0 )
        {
            moveSpeed = 0;
            fireDelay = 1000;
        }
    }

    void FixedUpdate()
    {
        Move();
    }

    void ProcessInputs()
    {

        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        float ShootH = Input.GetAxisRaw("ShootingHor");
        float ShootV = Input.GetAxisRaw("ShootingVert");

        if((ShootH !=0 || ShootV !=0) && Time.time > lastFire + fireDelay)
        {
            Shoot(ShootH, ShootV);
            lastFire = Time.time;
        }

        if (moveDirection !=Vector2.zero)
        {
            animator.SetFloat("ruchX", moveDirection.x);
            animator.SetFloat("ruchY", moveDirection.y);
            animator.SetBool("moving", true);
        }
        else
        {
            animator.SetBool("moving", false);
        }
        

        moveDirection = new Vector2(moveX, moveY).normalized;

        if (moveX < 0 && obrot)
        {
            Flip();
        }
        else if (moveX > 0 && !obrot)
        {
            Flip();
        }
      

    }

    void Shoot(float x, float y)
    {
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation) as GameObject;
        bullet.AddComponent<Rigidbody2D>().gravityScale = 0;
        bullet.GetComponent<Rigidbody2D>().velocity = new Vector3(
            (x < 0) ? Mathf.Floor(x) * bulletSpeed : Mathf.Ceil(x) * bulletSpeed,
            (y < 0) ? Mathf.Floor(y) * bulletSpeed : Mathf.Ceil(y) * bulletSpeed,
            0);
    }
    
    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }

    void Flip()
    {
        obrot = !obrot;
        transform.Rotate(0f, 180f, 0f);

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("enemy"))
        {
            GetComponent<hpScript>().health -= 1;


        }
        if (col.gameObject.tag.Equals("hpTag") && GetComponent<hpScript>().health < GetComponent<hpScript>().numOfHearts)
        {
            Destroy(col.gameObject);
            GetComponent<hpScript>().health += 1;
        }
    }
    
     
    }

    

 


