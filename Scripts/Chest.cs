using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Collectable
{
    public Sprite emptyChest;
    public int goldAmount = 10;

    protected override void OnCollect()
    {
        if (!collected)
        {
            collected = true;
            GetComponent<SpriteRenderer>().sprite = emptyChest;
            GameManager.instance.ShowText("Você encontrou um diário velho...!", 25, Color.blue, transform.position, Vector3.up * 30, 3.0f);
        }
    }
}
