using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float moveSpeed = 0;

    public GameObject flag;

    public float ratio;

    Vector2 startPos;

    //public bool holding = false;
    void Start()
    {
        ratio = 0.994f;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && moveSpeed == 0 && transform.position.x == -7)
        {
            startPos = Input.mousePosition;
        }
        if (Input.GetMouseButtonUp(0) && moveSpeed == 0 && transform.position.x == -7)
        {
            Vector2 endPos = Input.mousePosition;

            float swipeLength = endPos.x - startPos.x;

            //if (swipeLength < 0)
            //    swipeLength = -swipeLength;

            if (swipeLength > 0)
            {
                moveSpeed = swipeLength / 18000;
            }

            GetComponent<AudioSource>().Play();
        }

        transform.Translate(moveSpeed, 0, 0);

        //==

        if (moveSpeed > 0)
        {
            moveSpeed *= ratio;
        }
        if (moveSpeed < 0.0005)
        {
            moveSpeed = 0;
        }
    }
}
