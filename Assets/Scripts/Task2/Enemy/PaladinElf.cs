using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaladinElf : Paladin
{
    protected override void UseSpecialAttack()
    {
        Debug.Log("Я паладин-эльф. Атака также временно уменьшает получаемый урон!");
    }
}
