using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel
{
    public int NormalizedHp { get { return Hp / MaxHp; } }
    public bool IsHpChanged { get; private set; }

    private int Hp { get; set; }
    private int MaxHp { get; set; }

    public PlayerModel(int maxHp)
    {
        MaxHp = maxHp;
        Hp = MaxHp;
    }

    public void LateUpdate()
    {
        IsHpChanged = false;
    }

    public void ReceiveDamage(int damage)
    {
        Hp = Hp - damage;
        IsHpChanged = true;
    }


}
