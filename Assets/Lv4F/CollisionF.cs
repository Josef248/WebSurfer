using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class CollisionF : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3( 3f * Time.deltaTime, 0, 0 );
    }
}
