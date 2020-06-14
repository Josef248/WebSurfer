using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementF : MonoBehaviour
{

    bool moveAllowed;
    Collider2D col;
    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            if (touch.phase == TouchPhase.Began)
            {
                Collider2D touchedCollider = Physics2D.OverlapPoint(touchPosition);
                if (col == touchedCollider)
                {
                    moveAllowed = true;
                }
            }
            if (touch.phase == TouchPhase.Moved)
            {
                if (moveAllowed)
                {
                    //touchPosition.y = -4.62;
                    transform.position = new Vector2(touchPosition.x, -4.62f); //touchPosition.y);
                   
                }
            }
            if (touch.phase == TouchPhase.Ended)
            {
                moveAllowed = false;
            }

        }
    }
}
