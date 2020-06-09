using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Respawn : MonoBehaviour
{

    public GameObject prefab;
    private GameObject link;

    public float respawnTime = 0.3f;
    private Vector2 screenBounds;

    public int numberLink = 2;
    public int stop = 9;

    private int numLink_1;

    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

        PlayerPrefs.SetInt("numeroLink",0);
        StartCoroutine(linkWave(numberLink));

    }

    private void spawnLink()
    {
        link = Instantiate(prefab) as GameObject;
        link.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
        link.transform.SetParent(GameObject.FindGameObjectWithTag("Background").transform, false);

        //do {

            link.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x) * 2 / 3, Random.Range(-screenBounds.y, screenBounds.y) * 2 / 3);

      // } while (Physics2D.OverlapBox(link.transform.position, 100f, 0f);
        


    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("2 oggetti si sono collisi colEXIT");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("2 oggetti si sono collisi triggerEXIT");
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("2 oggetti si sono collisi ColisSTAY");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("2 oggetti si sono collisi ColisENTER");
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("2 oggetti si sono collisi STAY");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        Debug.Log("2 oggetti si sono collisi");
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



    void Update()
    {
        numLink_1 = PlayerPrefs.GetInt("numeroLink");

        if(numLink_1 == numberLink && numLink_1 <= stop)
        {
            numLink_1 = 0;
            PlayerPrefs.SetInt("numeroLink", numLink_1);

            numberLink += 2;

            StartCoroutine(linkWave(numberLink));

            //Debug.Log("numLink_1 : " + numLink_1 + " , numberLink : " + numberLink);
        }


    }

}