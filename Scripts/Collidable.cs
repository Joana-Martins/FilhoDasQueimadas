using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collidable : MonoBehaviour
{
    public ContactFilter2D filter;
    private BoxCollider2D boxCollider;
    private Collider2D[] hits = new Collider2D[10];

    private int check = 1;

    protected virtual void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    protected virtual void Update()
    {
        //Colisão
        boxCollider.OverlapCollider(filter, hits);
        for (int i = 0; i < hits.Length; i++)
        {
            if (hits[i] == null)
                continue;

            OnCollide(hits[i]);
            hits[i] = null;
        }
    }

    protected virtual void OnCollide(Collider2D coll)
    {
        if (check == 1)
        {
            GameManager.instance.ShowText("Você precisa de uma chave para abrir...", 25, Color.red, transform.position, Vector3.up * 25, 3.0f);
            check = 0;
        }

    }
}
