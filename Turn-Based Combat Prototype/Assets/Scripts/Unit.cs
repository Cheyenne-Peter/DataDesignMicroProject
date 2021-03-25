using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public string unitName;
    public int unitLevel;

    public int enemydamage;
    public int lowDamage;
    public int mediumDamage;
    public int highDamage;

    public int maxHP;
    public int currentHP;

    public void Update()
    {
        enemydamage = Random.Range(5, 15);
    }

    public bool TakeDamage(int dam)
    {
        currentHP -= dam;

        if (currentHP <= 0)
            return true;
        else
            return false;
    }

    public void Heal(int amount)
    {
        currentHP += amount;
        if (currentHP > maxHP)
            currentHP = maxHP;
    }
}
