using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class moveTo : Captcha
{
    //int i = 0;
   // int score=0;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(3.36f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 targetPosition = new Vector2(-4.19f, 0);
        if ((Vector2)transform.position != targetPosition)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, 3 * Time.deltaTime);
        }
    }

    /*private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "pg")
        {
            verifica(l.GetComponent<TextMeshProUGUI>().text);
            Destroy(this);
        }
    }

    public void verifica(String a)
    {
        if (a == arr[i].ToString())
        {
            score++;
        }else
        {
            Time.timeScale = 0;
        }

        i++;
    }
    */
}
