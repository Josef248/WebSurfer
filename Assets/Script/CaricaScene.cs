﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CaricaScene : MonoBehaviour
{
    public static bool gamePaused = false;


    public void pausa()
    {
        if (gamePaused)
        {
            Time.timeScale = 1;
            gamePaused = false;
        }
        else
        {
            Time.timeScale = 0;
            gamePaused = true;
        }
    }




    public void openMap()
    {
        PlayerPrefs.SetInt("Tempo", 0);
        SceneManager.LoadScene("Mappa");
    }

    public void openHome()
    {
        PlayerPrefs.SetInt("Tempo", 0);
        SceneManager.LoadScene("Home");
    }



    public void spiegazioneLv1()
    {
        Debug.Log("Caricamento spiega lv1");
        SceneManager.LoadScene("SpiegazioneLv1");
    }

    public void spiegazioneLv2()
    {
        Debug.Log("Caricamento spiega lv2");
        SceneManager.LoadScene("SpiegazioneLv2");
    }

    public void spiegazioneLv3()
    {
        Debug.Log("Caricamento spiega lv3");
        SceneManager.LoadScene("SpiegazioneLv3");
    }

    public void spiegazioneLv4()
    {
        Debug.Log("Caricamento spiega lv4");
        SceneManager.LoadScene("SpiegazioneLv4");
    }




    public void playGame1()
    {
        Debug.Log("Caricamento lv1");
        SceneManager.LoadScene("lv1");
    }

    public void playGame2()
    {
        Debug.Log("Caricamento lv2");
        SceneManager.LoadScene("lv2");
    }

    public void playGame3()
    {
        Debug.Log("Caricamento lv3");
        SceneManager.LoadScene("lv3");
    }

    public void playGame4()
    {
        Debug.Log("Caricamento lv4");
        SceneManager.LoadScene("lv4");
    }

   /*
    public void riprova()
    {
        SceneManager.LoadScene("lv1");
    }

    public void mappa()
    {
        SceneManager.LoadScene("Mappa");
    }*/

    public void ricaricaScena()
    {
        int tempo = (int) Time.time;
        PlayerPrefs.SetInt("Tempo", tempo);

        Debug.LogWarning("Tempo salvato : " + tempo);

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }

}
