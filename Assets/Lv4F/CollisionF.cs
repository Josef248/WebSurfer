using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class CollisionF : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(3.69f, -3.08f);
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 targetPosition = new Vector2(-4f, -3.08f);
        if ((Vector2)transform.position != targetPosition)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, 2.5f * Time.deltaTime);
        }
    }
}
