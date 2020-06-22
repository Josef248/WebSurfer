using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI punteggio;
    public TextMeshProUGUI tempo;
    private int tempoInt = 60;
    private int punteggioInt = 0;
    private float secondi = 0.0f;
    public GameObject gameOver;


    public void Start()
    {
        PlayerPrefs.SetInt("Score1", punteggioInt);
        punteggio.text = PlayerPrefs.GetInt("Score1").ToString();
        tempo.text = tempoInt.ToString();
        Time.timeScale = 1f;
    }

    public void isHighscore()
    {
        int record = PlayerPrefs.GetInt("Highscore1");
        if (record < PlayerPrefs.GetInt("Score1"))
        {
            PlayerPrefs.SetInt("Highscore1", PlayerPrefs.GetInt("Score1"));
        }
    }


    private void Update()
    {
        punteggio.text = PlayerPrefs.GetInt("Score1").ToString();
        
        if(Time.time > secondi)
        {

            Debug.Log("tempo trascorso : " + tempoInt);
            
            if(secondi < PlayerPrefs.GetInt("Tempo"))
            {
                secondi = PlayerPrefs.GetInt("Tempo");
            }

                secondi++;
                tempoInt--;

                if (tempoInt > 0)
                {
                    tempo.text = tempoInt.ToString();
                }
                else
                {
                    Time.timeScale = 0f;
                    isHighscore();
                    gameOver.SetActive(true);
                }
            
            

        }

    }

   
}
