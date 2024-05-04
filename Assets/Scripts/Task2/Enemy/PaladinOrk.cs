using UnityEngine;

public class PaladinOrk : Paladin
{
    protected override void UseSpecialAttack()
    {
        Debug.Log("Я паладин-орк. Ярость орка наносит двойной урон!");
    }
}
