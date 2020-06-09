using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpawnNo: MonoBehaviour
{
    public GameObject FoodPrefab;

    /*public Transform BorderTop;
    public Transform BorderBottom;
    public Transform BorderLeft;
    public Transform BorderRight;
    public Transform Obstacle;*/

    public LayerMask layerMask; //Additional variable so you can control which layer you don't want to be detected in raycast

    Vector2 pos, screenBounds;

    // Use this for initialization
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

        for (int i = 0; i < 10; i++)
        {
            Spawn();
        }
    }

    /*
    void Spawn()
    {
        pos.x = Random.Range(BorderLeft.position.x + 5, BorderRight.position.x - 5);

        pos.y = Random.Range(BorderBottom.position.y + 5, BorderTop.position.y - 5);

        Instantiate(FoodPrefab, pos, Quaternion.identity);

    }*/

    
    void Spawn()
    {
        StartCoroutine(GameObjectExists());
    }


    IEnumerator GameObjectExists()
    {

        do
        {
            yield return null;
            pos.x = Random.Range(-screenBounds.x, screenBounds.x);
            pos.y = Random.Range(-screenBounds.y, screenBounds.y);

            Debug.Log("screenBound x : " + screenBounds.x + " , screenBound y : " + screenBounds.y);

        } while (Physics2D.OverlapCircle(new Vector2(pos.x,pos.y), 1f, layerMask)); //1f is the radius of your food gameObject.

        GameObject link = Instantiate(FoodPrefab, pos, Quaternion.identity);
        link.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
        link.transform.SetParent(GameObject.FindGameObjectWithTag("Background").transform, false);
        yield return null;
    }


    // Update is called once per frame
    void Update()
    {

    }




}
