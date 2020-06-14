using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour
{

    public GameObject enemy;
    RectTransform misure;
    float width, height;

    
    Vector2 whereToSpawn;
    Vector2 screenBounds;

    Vector2[] otherPosition = new Vector2[10];
    int numSpwan = 0;

    public float SpawnRate = 2f;
    float nextSpawn = 0.0f;



    
    void Start()
    {
        misure = (RectTransform)enemy.transform;
        width = misure.rect.width;
        height = misure.rect.height;

        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

    }

    Vector2 creaRandom()
    {
        Vector2 pos;
        bool okei = false;

        do {

            
            pos.x = Random.Range(-500.0f, 500.0f);
            pos.y = Random.Range(-500.0f, 500.0f);
            
            /*
            pos.x = Random.Range(-screenBounds.x, screenBounds.x) * 2 / 3;
            pos.y = Random.Range(-screenBounds.y, screenBounds.y) * 2 / 3;
            */

            if (numSpwan == 0)
            {
                otherPosition[numSpwan] = pos;
                okei = true;

                Debug.Log("Prima volta");
            }
            else
            {
                if(!esistePosition(otherPosition, pos))
                {
                    okei = true;
                    otherPosition[numSpwan] = pos;

                    Debug.Log("Nuovo mai esistito");

                }
            }

        } while (okei == false);

        numSpwan++;
        return pos;
    }

    bool esistePosition(Vector2[] posizioni, Vector2 nuovoOggetto)
    {
        int i;

        for (i=0; i<posizioni.Length; i++)
        {
            if( Mathf.Abs(posizioni[i].x - nuovoOggetto.x) <= width && Mathf.Abs(posizioni[i].y - nuovoOggetto.y) <= height)
            {
                return true;
            }
            
        }

        return false;
    }





    void Update()
    {

        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + SpawnRate;

            whereToSpawn = creaRandom();

            GameObject link = Instantiate(enemy, whereToSpawn, Quaternion.identity);
            link.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
            link.transform.SetParent(GameObject.FindGameObjectWithTag("Background").transform, false);

        }


    }
}
