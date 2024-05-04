using System.Collections.Generic;
using Task2.Spawner;
using UnityEngine;

namespace Task2
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private List<EnemyFactory> _factories;
        [SerializeField] private List<EnemySpawner> _spawners;
        [SerializeField] private InputHandler _inputHandler;
    
        private void Awake()
        {
            Dictionary<RaceType, EnemyFactory> dictionary = new Dictionary<RaceType, EnemyFactory>();
        
            dictionary.Add(RaceType.Elf, _factories.Find(factory => factory.GetType() == typeof(ElfFactory)));
            dictionary.Add(RaceType.Ork, _factories.Find(factory => factory.GetType() == typeof(OrkFactory)));

            FactoryHandler factoryHandler = new (dictionary);
            SpawnerHandler spawnerHandler = new (_spawners, _inputHandler);
            spawnerHandler.InitSpawners(factoryHandler);
        }
    }
}