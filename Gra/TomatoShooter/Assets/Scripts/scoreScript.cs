using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreScript : MonoBehaviour
{
    public static int scoreValue = 0;
    Text score;
    public static int Adder = 1;
    public static int AdderBoss = 10;


    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
        score.text = "Score: " + scoreValue;
    }
    
    
       
    
}
