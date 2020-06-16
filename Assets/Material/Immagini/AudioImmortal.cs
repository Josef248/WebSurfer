using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class AudioImmortal : MonoBehaviour
{

    //static AudioImmortal instance = null;

    void Awake()
    {

        DontDestroyOnLoad(transform.gameObject);
        
        /*if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }*/
    }

   
}
