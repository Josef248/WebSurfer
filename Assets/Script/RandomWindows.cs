using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomWindows : Spawner
{

   /* public float minX;
    public float maxX;
    public float minY;
    public float maxY;*/
    public Vector2 worldCenterOfMass;

    //Vector2 targetPosition;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed += (float)0.0005;
        /*if ((Vector2)transform.position != targetPosition)
        {*/
            transform.position = Vector2.MoveTowards(transform.position, worldCenterOfMass, speed * Time.deltaTime);
        /*}
        else
        {
            targetPosition = GetRandomPosition();
        }*/
       /* if ((Vector2)transform.position != targetPosition)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }
        else
        {
            targetPosition = GetRandomPosition();
        }*/
    }

    Vector2 GetRandomPosition()
    {
        float randomX;
        float randomY;
        do
        {
            randomX = Random.Range(minX, maxX);
            randomY = Random.Range(minY, maxY);

        } while (randomY < 1.50 && randomY > -3.50);
        return new Vector2(randomX, randomY);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "browser")
        {
            Healt.healt -= 1;
            //transform.position = Vector2.MoveTowards(GetRandomPosition(), worldCenterOfMass, speed * Time.deltaTime);
            spawn();
            Destroy(this.page);
        }
    }
}
