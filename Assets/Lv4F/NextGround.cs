using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class NextGround : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3 (3 * Time.deltaTime, 0, 0);
        if (transform.position.x <= -4.79)
        {
            transform.position = new Vector3 (4.79f , transform.position.y, 0f);
        }
    }
}
