using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletBossScript : MonoBehaviour
{
    public float lifeTime = 5f;
    private float rotZ;
    public float RotationSpeed;
    public float moveSpeed;
    Rigidbody2D rb;

    public GameObject target;
    Vector2 moveDir;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DeathDelay());
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.Find("Player");
        moveDir = (target.transform.position - transform.position).normalized * moveSpeed;
        rb.velocity = new Vector2(moveDir.x, moveDir.y);
        
        
    }
    void Update()
    {
        rotZ += Time.deltaTime * RotationSpeed;
        transform.rotation = Quaternion.Euler(0, 0, rotZ);
    }
    // Update is called once per frame

    IEnumerator DeathDelay()
    {
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }
}
