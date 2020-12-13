using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorScript : MonoBehaviour
{
    public bool doorOpen;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        doorOpen = false;
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            StartCoroutine(zmianaDrzwi());
        }
    }
    IEnumerator zmianaDrzwi()
    {
        doorOpen = !doorOpen; anim.SetBool("Open", doorOpen);
        yield return new WaitForSeconds(1);
        gameObject.GetComponent<Collider2D>().enabled = !gameObject.GetComponent<Collider2D>().enabled;
    }
}
