using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hpScript : MonoBehaviour
{
    public GameObject DeathUI;
    public int health;
    public int numOfHearts;
    public Animator animator;
    public float waitSec;


    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health > numOfHearts)
        {
            health = numOfHearts;
        }
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
        if (health <= 0)
        {
            StartCoroutine(MenuSec());


        }
       


    }
    IEnumerator MenuSec()
    {

        Debug.Log("DEAD");
        animator.SetBool("dead", true);
        yield return new WaitForSeconds(waitSec);

        DeathUI.gameObject.SetActive(true);
        Destroy(gameObject, 10f);



    }
}
