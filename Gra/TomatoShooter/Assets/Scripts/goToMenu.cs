using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goToMenu : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("tomatogame1");
    }
}
