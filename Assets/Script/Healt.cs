using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class Healt : MonoBehaviour
{
    public static int healt;
    public Image[] hearts;
    public GameObject vinto;
    public GameObject perso;

    public GameObject browser;
    public GameObject finestre;
    //public Sprite spr;

    // Start is called before the first frame update
    void Start()
    {
        healt = 3;
        hearts[0].enabled = true;
        hearts[1].enabled = true;
        hearts[2].enabled = true;
    }


    public void isHighscore()
    {
        int record = PlayerPrefs.GetInt("Highscore2");
        if (record < PlayerPrefs.GetInt("Score2"))
        {
            PlayerPrefs.SetInt("Highscore2", PlayerPrefs.GetInt("Score2"));
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (healt == 2)
        {
            hearts[0].enabled = false;
        }
        else if (healt == 1)
        {
            hearts[1].enabled = false;
        }
        else if (healt == 0)
        {
            hearts[2].enabled = false;
            //SceneManager.LoadScene("Mappa");
            Time.timeScale = 0;

            browser.SetActive(false);
            finestre.SetActive(false);
            isHighscore();

            perso.SetActive(true);

        }
    }
}
