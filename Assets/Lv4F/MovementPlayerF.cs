using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net.NetworkInformation;
using UnityEngine;

public class MovementPlayerF : MonoBehaviour
{

    public bool player;
    // Start is called before the first frame update
    void Start()
    {
        player = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && player == false)
        {
            GetComponent<Rigidbody2D> ().velocity = new Vector3(0,10,0);
            player = true;
        }


        if (Input.GetMouseButtonDown(0) && player == false)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 10, 0);
            player = true;

            Vector3 clickPosition = -Vector3.one;

            clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition + new Vector3(0, 0, 5f));


        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Finish" )
        {
            player = false;
        }

        if (coll.gameObject.tag == "Respawn")
        {
            Application.LoadLevel( "lv4F" );
        }
    }
}
