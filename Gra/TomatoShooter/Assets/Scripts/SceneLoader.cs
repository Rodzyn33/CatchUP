using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public GameObject DeathUI;
    public void LoadGame()
    {
        scoreScript.scoreValue = 0;
        SceneManager.LoadScene("TomatoGame");
        DeathUI.gameObject.SetActive(false);
        
    }
}
