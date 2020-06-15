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
    GameObject l2;
    //public TextMeshProUGUI l;

    void Start()
    {
        captchaGen();
        captchaGen2();
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
            c = Random.Range(0,20);
            x++;
            coord = new Vector2(x, 2);
            t = Random.Range(0, 3);
            t = 0;
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
        char[] lett = {'a','b','c','d','e','f','g','h','i','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
        l.GetComponent<TextMeshProUGUI>().text = lett[Random.Range(0, 23)].ToString();
        //Instantiate(l, GetRandomPosition(), Quaternion.identity);
        l2=Instantiate(l, new Vector2(2.35f, -2.2f), Quaternion.identity);
        l2.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
        //l2.transform.localScale = new Vector2(1,1);
    }


}
