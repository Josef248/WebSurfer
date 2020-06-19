using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RecordScoreProfile : MonoBehaviour
{
    public TextMeshProUGUI Score1;
    //public TextMeshProUGUI Highscore;
    public int numeroLivello;

    void Start()
    {
        //score.text = PlayerPrefs.GetInt("Score" + numeroLivello).ToString();
        Score1.text = PlayerPrefs.GetInt("Highscore" + numeroLivello).ToString();
    }
}
