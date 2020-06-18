using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SalvaScore : MonoBehaviour
{
    public TextMeshProUGUI score;
    public TextMeshProUGUI Highscore;
    public int numeroLivello;

    void Start()
    {
        score.text = PlayerPrefs.GetInt("Score" + numeroLivello).ToString();
        Highscore.text = PlayerPrefs.GetInt("Highscore" + numeroLivello).ToString();
    }

   
}
