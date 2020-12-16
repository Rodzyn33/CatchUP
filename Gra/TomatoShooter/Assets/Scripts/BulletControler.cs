using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControler : MonoBehaviour
{
    public float lifeTime;
    public GameObject shotParticles;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DeathDelay());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator DeathDelay()
    {
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Statistics>())
            collision.gameObject.GetComponent<Statistics>().takeDamage(5);
        if (!(collision.name == "Player"))
        {
            if (!(collision.name == "CameraBox"))
            {
                if (!(collision.gameObject.tag.Equals("spikes")))
                {
                    if(!(collision.gameObject.tag.Equals("hpTag")))
                    {
                        if (!(collision.gameObject.tag.Equals("hpboost")))
                            Instantiate(shotParticles, transform.position, Quaternion.identity);
                            Destroy(this.gameObject);
                    }
                }
                    
            }
                
        }

        
    }
}
