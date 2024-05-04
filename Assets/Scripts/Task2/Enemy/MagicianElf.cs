using UnityEngine;

public class MagicianElf : Magician
{
    protected override void UseSpell()
    {
        Debug.Log("Я маг-эльф. Заклинание усилено эльфийским зельем!");
    }
}