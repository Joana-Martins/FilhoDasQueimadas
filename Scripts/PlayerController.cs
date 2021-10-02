using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 

 
{
    private BoxCollider2D boxCollider;
    private Vector3 moveDelta;
    private RaycastHit2D hit;
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

        if (moveDelta.x < 0)
        {
            transform.localScale = new Vector3(1f, 1f, 1);            
        }
        else if (moveDelta.x > 0)
        {
            transform.localScale = new Vector3(-1f, 1f, 1);
        }
        //Verifica se há caminho disponível na direção, castando um boxcollider para testar se há ou não algum obstáculo
        hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(0, moveDelta.y), Mathf.Abs(moveDelta.y * Time.deltaTime), LayerMask.GetMask("Actor", "Blocking"));
        if(hit.collider == null)
        {
        //Movimento
        transform.Translate(0, moveDelta.y * Time.deltaTime * 3, 0);    
        }

        hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(moveDelta.x, 0), Mathf.Abs(moveDelta.x  * Time.deltaTime), LayerMask.GetMask("Actor", "Blocking"));
        if (hit.collider == null)
        {
            //Movimento
            transform.Translate(moveDelta.x * Time.deltaTime * 5, 0, 0);
        }


    }
}
