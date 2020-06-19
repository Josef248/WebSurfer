using System.Collections;
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
        SceneManager.LoadScene("Mappa");
    }

    public void openHome()
    {
        SceneManager.LoadScene("Home");
    }




    public void tutorialLv1()
    {
        Debug.Log("Caricamento tutorial Lv1");
        SceneManager.LoadScene("TutorialLv1");
    }

    public void tutorialLv2()
    {
        Debug.Log("Caricamento tutorial Lv2");
        SceneManager.LoadScene("TutorialLv2");
    }

    public void tutorialLv3()
    {
        Debug.Log("Caricamento tutorial Lv2");
        SceneManager.LoadScene("TutorialLv3");
    }

    public void tutorialLv4()
    {
        Debug.Log("Caricamento tutorial Lv2");
        SceneManager.LoadScene("TutorialLv4");
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




    public void concettoLv1()
    {
        Debug.Log("Caricamento concetto lv1");
        SceneManager.LoadScene("Concetto1");
    }

    public void concettoLv2()
    {
        Debug.Log("Caricamento concetto lv2");
        SceneManager.LoadScene("Concetto2");
    }

    public void concettoLv3()
    {
        Debug.Log("Caricamento concetto lv3");
        SceneManager.LoadScene("Concetto3");
    }

    public void concettoLv4()
    {
        Debug.Log("Caricamento concetto lv4");
        SceneManager.LoadScene("Concetto4");
    }





    public void playGame1()
    {
        Debug.Log("Caricamento lv1");
        int tempo = (int)Time.time;
        PlayerPrefs.SetInt("Tempo", tempo);
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
        GameOver.isPlayerDead = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("lv3");
    }

    public void playGame4()
    {
        Debug.Log("Caricamento lv4");
        SceneManager.LoadScene("lv4");
    }


    public void ricaricaScena()
    {
        int tempo = (int) Time.time;
        PlayerPrefs.SetInt("Tempo", tempo);

        //Debug.LogWarning("Tempo salvato : " + tempo);

        GameOver.isPlayerDead = false;

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }

}
