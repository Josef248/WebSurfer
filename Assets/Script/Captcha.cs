using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Captcha : MonoBehaviour
{
    public GameObject[] lettere;
    public GameObject[] lettere1;
    public GameObject[] lettere2;
    public GameObject l;
    public GameObject l2;
    public static int[] arr = new int[10];
    //int pos = 0;
    //public TextMeshProUGUI l;

    void Start()
    {
        captchaGen();
        //captchaGen2(0);
        InvokeRepeating("captchaGen2", 1, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void captchaGen()
    {
        float x = -3f;
        int c;
        int t;
        Vector2 coord = new Vector2(x, 2);
        for (int i = 0; i < 4; i++)
        {
            c = Random.Range(0,22);
            x++;
            coord = new Vector2(x, 2);
           // t = Random.Range(0, 3);
            t = 0;
            arr[i] = c;
            switch (t)
            {
                case 0:
                    Instantiate(lettere[c], coord, Quaternion.identity);
                    break;
                case 1:
                    Instantiate(lettere1[c], coord, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(lettere2[c], coord, Quaternion.identity);
                    break;
            }
        }
    }

    void captchaGen2()
    {
        char[] lett = {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
        //l.GetComponent<TextMeshProUGUI>().text = lett[Random.Range(0, 23)].ToString();
        l.GetComponent<TextMeshProUGUI>().text = lett[arr[Random.Range(0,5)]].ToString();
        //Instantiate(l, GetRandomPosition(), Quaternion.identity);
        l2 =Instantiate(l, new Vector2(2.35f, -2.2f), Quaternion.identity);
        l2.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
        //l2.transform.localScale = new Vector2(1,1);
        //pos++;
        /*if (pos == 4)
        {
            pos = 0;
        }*/
    }


}
