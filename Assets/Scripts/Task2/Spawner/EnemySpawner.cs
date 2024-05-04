using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Task2.Spawner
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] private List<Transform> _spawnPoints;
    
        private readonly WaitForSeconds _cooldown = new(1);
    
        private FactoryHandler _factoryHandler;
        private EnemyFactory _enemyFactory;
    
        public void Init(FactoryHandler factoryHandler)
        {
            _factoryHandler = factoryHandler;

            _enemyFactory = _factoryHandler.GetFactory();
            StartCoroutine(Spawn());
        }

        public void ChangeFactory()
        {
            _enemyFactory = _factoryHandler.GetOtherFactory(_enemyFactory);
        }
    
        private IEnumerator Spawn()
        {
            while (true)
            {
                Enemy enemy = _enemyFactory.Get();
                enemy.transform.position = _spawnPoints[Random.Range(0, _spawnPoints.Count)].position;
                enemy.Attack();

                yield return _cooldown;
            }
        }
    }
}