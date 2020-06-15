using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(3.36f, -2.2f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 targetPosition = new Vector2(-4.19f, -2.2f);
        if ((Vector2)transform.position != targetPosition)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, 1 * Time.deltaTime);
        }
    }

}
