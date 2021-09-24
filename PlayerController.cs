using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 

 
{
    private BoxCollider2D boxCollider;
    private Vector3 moveDelta;
    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void FixedUpdate()
    {

        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        moveDelta = new Vector3(x, y, 0);
        // Debug.Log(x);
        //Debug.Log(y);

        if (moveDelta.x > 0)
        {
            transform.localScale = Vector3.one;            
        }
        if (moveDelta.x < 0)
        {
            transform.localScale = Vector3.one * -1;
        }

    }
}
