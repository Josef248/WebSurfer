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
        PlayerPrefs.SetInt("Score", punteggioInt);
        punteggio.text = PlayerPrefs.GetInt("Score").ToString();
        tempo.text = tempoInt.ToString();
        Time.timeScale = 1f;
    }

    public void isHighscore()
    {
        int record = PlayerPrefs.GetInt("Highscore");
        if (record < PlayerPrefs.GetInt("Score"))
        {
            PlayerPrefs.SetInt("Highscore", PlayerPrefs.GetInt("Score"));
        }
    }


    private void Update()
    {
        punteggio.text = PlayerPrefs.GetInt("Score").ToString();
        
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
