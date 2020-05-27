using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void openMap()
    {
        SceneManager.LoadScene("scenaMappa");
    }

    public void quitGame()
    {
        Application.Quit();
    }



}
