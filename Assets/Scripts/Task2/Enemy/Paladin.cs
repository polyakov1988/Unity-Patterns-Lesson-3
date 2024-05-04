using UnityEngine;

public class Paladin : Enemy
{
    public override void Attack()
    {
        UseSpecialAttack();
    }
    
    protected virtual void UseSpecialAttack()
    {
        Debug.Log("Я паладин. Использую специальную атаку!");
    }
}
