using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pauseMenu;

    public void Pausa()
    {
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
    }

    public void Riprendi()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
    }
}
