using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CaricaScene : MonoBehaviour
{
    public void openMap()
    {
        PlayerPrefs.SetInt("Tempo", 0);
        SceneManager.LoadScene("Mappa");

    }

    public void openLivelloRedirect()
    {
        SceneManager.LoadScene("LivelloRed");
    }

    public void ricaricaScena()
    {
        int tempo = (int) Time.time;
        PlayerPrefs.SetInt("Tempo", tempo);

        Debug.LogWarning("Tempo salvato : " + tempo);

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }

}
