using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreF : MonoBehaviour
{
    public Text punteggio;
    public static int punteggioInt = 0;

    public void Start()
    {
        PlayerPrefs.SetInt("Score3", punteggioInt);
        punteggio.text = PlayerPrefs.GetInt("Score3").ToString();

    }

    private void Update()
    {

        punteggio.text = PlayerPrefs.GetInt("Score3").ToString();
    }


    /*
    public void SaliPunteggio()
    {
        punteggioInt += 1;
        PlayerPrefs.SetInt("HighScore", punteggioInt);
        punteggio.text = PlayerPrefs.GetInt("HighScore").ToString();
        Debug.Log("Punteggio totale = " + punteggioInt);
    }
    */

}
