using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private int score;
    private TextMeshProUGUI Text;
    private float sec;
    private bool flag;

    // Start is called before the first frame update
    void Start()
    {
        flag = true;
        sec = 0.0f;
        score = 0;
        Text = FindObjectOfType<TextMeshProUGUI>();
        Text.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        while (flag)
        {
            //sec = Time.time;
            //score = (int)(sec);
            //Text.text = score.ToString();
        }
    }
}
