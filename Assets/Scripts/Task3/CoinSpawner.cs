using System.Collections;
using UnityEngine;

namespace Task3
{
    public class CoinSpawner : MonoBehaviour
    {
        [SerializeField] private float _timeout;
    
        private CoinFactory _coinFactory;
        private SpawnPointHandler _spawnPointHandler;
        private WaitForSeconds _cooldown;

        private Coroutine _coroutine;

        private void OnDisable()
        {
            _spawnPointHandler.FreePointsEnded -= StopSpawn;
        }

        public void Init(CoinFactory coinFactory, SpawnPointHandler spawnPointHandler)
        {
            _coinFactory = coinFactory;
            _spawnPointHandler = spawnPointHandler;
            _cooldown = new WaitForSeconds(_timeout);
            _spawnPointHandler.FreePointsEnded += StopSpawn;

            _coroutine = StartCoroutine(Spawn());
        }

        private IEnumerator Spawn()
        {
            while (true)
            {
                
                
                Coin coin = _coinFactory.Get();
                coin.transform.position = _spawnPointHandler.GetSpawnPoint().position;

                yield return _cooldown;
            }
        }

        private void StopSpawn()
        {
            if (_coroutine != null)
                StopCoroutine(_coroutine);
        }
    }
}
