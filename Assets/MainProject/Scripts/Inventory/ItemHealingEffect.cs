using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="ItemEffect/Consumable/Health")]
public class ItemHealingEffect : ItemEffect
{
    public int healingPoint = 500;

    public override bool ExecuteRole()
    {
        Debug.Log("힐링");

        GameManager.Inst.MainPlayer.curHealth += healingPoint;


        return true;
    }
}


