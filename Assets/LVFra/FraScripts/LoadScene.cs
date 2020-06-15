using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{

    //int puntiOra;


    public void Load()
    {
        //puntiOra = 0;
        GameOver.isPlayerDead = false;
        Time.timeScale = 1;

        SceneManager.LoadScene("Mappa");
    }
}