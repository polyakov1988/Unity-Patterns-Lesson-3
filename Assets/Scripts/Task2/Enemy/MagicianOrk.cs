using UnityEngine;

public class MagicianOrk : Magician
{
    protected override void UseSpell()
    {
        Debug.Log("Я маг-орк. Заклинание усиливает урон на 3 хода!");
    }
}