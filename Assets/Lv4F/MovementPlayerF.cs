using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class MovementPlayerF : Captcha
{
    int i = 0;
    int score = 0;
    public bool player;
    int counter;
    public TextMeshProUGUI[] txt;
    // Start is called before the first frame update
    void Start()
    {
        player = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && player == false)
        {
            GetComponent<Rigidbody2D> ().velocity = new Vector3(0,10,0);
            player = true;
        }


        if (Input.GetMouseButtonDown(0) && player == false)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 10, 0);
            player = true;

            Vector3 clickPosition = -Vector3.one;

            clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition + new Vector3(0, 0, 5f));


        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Finish" )
        {
            player = false;
        }

        if (coll.gameObject.tag == "Respawn")
        {
            //SceneManager.LoadScene( "lv4G" );
        }
        /*if (coll.gameObject.tag == "lettera")
        {
            Debug.Log("aooo");
            //Destroy(this.l);
        }*/
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "lettera")
        {
            //Destroy(coll);
            Destroy(coll.GetComponent<TextMeshProUGUI>());
            //Destroy(this.l2);
            char c = coll.GetComponent<TextMeshProUGUI>().text[0];
            verifica(c);
            //Destroy(this);
        }
    }

    public void verifica(char a)
    {
        char[] lett = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        //char[] strVerify = new char[4];
        char c;

        if (a == lett[arr[i]])
        {
            score++;
            //strVerify[i] = lett[arr[i]];
            c = lett[arr[i]];
            txt[i].text = c.ToString();
        }
        else
        {
            SceneManager.LoadScene("lv4G");
        }

        i++;
    }

}
