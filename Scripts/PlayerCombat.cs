using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    private string unitName = GameInfo.PlayerName;
    private int unitLevel = GameInfo.PlayerLevel;

    public int damage;

    public int maxHp;
    public int currentHP;

    public bool TakeDamage(int damage)
    {
        currentHP -= damage;

        if (currentHP <= 0)
        {
            return true;
        }
        else
            return false;
    }

    public void Heal(int amount)
    {
        currentHP += amount;
        if (currentHP > maxHp)
            currentHP = maxHp;
    }
}
