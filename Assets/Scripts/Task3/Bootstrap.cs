using System.Collections.Generic;
using UnityEngine;

namespace Task3
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private CoinSpawner _coinSpawner;
        [SerializeField] private CoinFactory _coinFactory;
        [SerializeField] private List<SpawnPoint> _spawnPoints;
    
        private void Awake()
        {
            _coinSpawner.Init(_coinFactory, new SpawnPointHandler(_spawnPoints));
        }
    }
}