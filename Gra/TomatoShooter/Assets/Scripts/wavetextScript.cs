using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wavetextScript : MonoBehaviour
{
    private Text score;
    private int fala;


    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
        fala = GameObject.Find("GameManager").GetComponent<GameManagerScript>().wave;
    }
    private void LateUpdate()
    {
        fala = GameObject.Find("GameManager").GetComponent<GameManagerScript>().wave;
        score.text = "Wave: " + fala;
    }




}

