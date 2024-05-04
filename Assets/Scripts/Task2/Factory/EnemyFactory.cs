using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : ScriptableObject
{
    [SerializeField] private List<Enemy> _enemies;

    public Enemy Get()
    {
        return Instantiate(_enemies[Random.Range(0, _enemies.Count)]);
    }
}