using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class RespawnF : MonoBehaviour
{
    //private GameObject RipetiRoccia;
    public GameObject roccia;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating( "Respawn", 1,3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Respawn()
    {
        //RipetiRoccia = 
        //as GameObject;

        //Instantiate(roccia, transform.position, Quaternion.identity);


        Instantiate(roccia, new Vector2(3.8f, -3.08f), Quaternion.identity);
    }
}
