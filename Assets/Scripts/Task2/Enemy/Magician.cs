using UnityEngine;

public class Magician : Enemy
{
    public override void Attack()
    {
        UseSpell();
    }
    
    protected virtual void UseSpell()
    {
        Debug.Log("Я маг. Применяю заклинание!");
    }
}
