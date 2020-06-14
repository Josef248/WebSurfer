using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickIsole : MonoBehaviour
{
    public static bool gamePaused = false;
    public void playGame()
    {
        Debug.Log("Caricamento lv1");
        SceneManager.LoadScene("lv1");
    }
    public void playGame1()
    {
        Debug.Log("Caricamento lv1");
        SceneManager.LoadScene("lv2");
    }
    public void playGame2()
    {
        Debug.Log("Caricamento lv1");
        SceneManager.LoadScene("lv3");
    }
    public void playGame3()
    {
        Debug.Log("Caricamento lv1");
        SceneManager.LoadScene("lv4");
    }

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
    public void riprova()
    {
        SceneManager.LoadScene("lv1");
    }

    public void mappa()
    {
        SceneManager.LoadScene("Mappa");
    }
}
