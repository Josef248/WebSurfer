using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class sc : MonoBehaviour
{

    private TextMeshProUGUI Text;
    public static int score;

    void Start()
    {
       // score = 0;
        //Text = FindObjectOfType<TextMeshProUGUI>();
        Text.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        score = ((int)Time.time)*10;
        Text.text = score.ToString();
    }
}
