using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Respawn : MonoBehaviour
{

    public GameObject prefab;
    private GameObject link;
    public GameObject winner;

    RectTransform misure;
    float width, height;
    
    //private Vector2 screenBounds;
    private Vector2 whereToSpawn;
    private Vector2[] otherPosition = new Vector2[25];
    int numSpwan = 0;

    public float respawnTime = 0.3f;

    public int numberLink = 2;
    public int stop = 10;
    private int numLink_1 = 1;

    void Start()
    {
        //screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        Time.timeScale = 1f;

        misure = (RectTransform)prefab.transform;
        width = misure.rect.width;
        width *= 1.1f;
        height = misure.rect.height;
        height *= 1.1f;

        PlayerPrefs.SetInt("numeroLink", numLink_1);

        StartCoroutine(linkWave(numberLink));

    }

    Vector2 creaRandom()
    {
        Vector2 pos;
        bool okei = false;

        do
        {
            pos.x = Random.Range(-Screen.width, Screen.width)* 1 / 3;
            pos.y = Random.Range(-Screen.height, Screen.height)* 1 / 3;


            if (numSpwan == 0)
            {
                otherPosition[numSpwan] = pos;
                okei = true;

            }
            else
            {
                if (!esistePosition(otherPosition, pos))
                {
                    okei = true;
                    otherPosition[numSpwan] = pos;

                }
            }


        } while (okei == false);

        numSpwan++;
        return pos;
    }

    bool esistePosition(Vector2[] posizioni, Vector2 nuovoOggetto)
    {
        int i;

        for (i = 0; i < posizioni.Length; i++)
        {
            if (Mathf.Abs(posizioni[i].x - nuovoOggetto.x) <= width && Mathf.Abs(posizioni[i].y - nuovoOggetto.y) <= height)
            {
                return true;
            }

        }

        return false;
    }

    void clearPosition()
    {
        int i = 0;
        for (i = 0; i < numSpwan; i++)
        {
            otherPosition[i] = new Vector2();
        }
        numSpwan = 0;
    }


    private void spawnLink()
    {
        whereToSpawn = creaRandom();

        link = Instantiate(prefab, whereToSpawn, Quaternion.identity);
        link.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
        link.transform.SetParent(GameObject.FindGameObjectWithTag("Background").transform, false);


    }

    IEnumerator linkWave(int volte)
    {
        int i = 0;
        while (i<volte)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnLink();
            i++;
        }

    }

    public void isHighscore()
    {
        int record = PlayerPrefs.GetInt("Highscore1");
        if (record < PlayerPrefs.GetInt("Score1"))
        {
            PlayerPrefs.SetInt("Highscore1", PlayerPrefs.GetInt("Score1"));
        }
    }



    void Update()
    {
        numLink_1 = PlayerPrefs.GetInt("numeroLink");
        
        
        if(numLink_1 == numberLink && numLink_1 <= stop)
        {
            numLink_1 = 0;
            PlayerPrefs.SetInt("numeroLink", numLink_1);
            numberLink += 2;

            clearPosition();
            //numSpwan = 0;
            StartCoroutine(linkWave(numberLink));

            Debug.Log("numLink_1 : " + numLink_1 + " , numberLink : " + numberLink);
        }

        if(numLink_1 > numberLink && numLink_1 > stop)
        {
            Time.timeScale = 0f;
            isHighscore();
            winner.SetActive(true);
        }


    }

}