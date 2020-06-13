using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOverScreen : MonoBehaviour
{
    private Vector2 screenBounds;

    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    void Update()
    {
        if (transform.position.x < screenBounds.x)
        {
            Destroy(this.gameObject);
        }
    }
}


