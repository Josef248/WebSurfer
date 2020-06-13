using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SalvaScore : MonoBehaviour
{
    public TextMeshProUGUI score;
    public TextMeshProUGUI Highscore;

    void Start()
    {
        score.text = PlayerPrefs.GetInt("Score").ToString();
        Highscore.text = PlayerPrefs.GetInt("Highscore").ToString();
    }

   
}
