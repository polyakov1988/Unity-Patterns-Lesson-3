using System;
using System.Collections.Generic;
using Task2;
using Task2.Spawner;

public class SpawnerHandler : IDisposable
{
    private readonly List<EnemySpawner> _spawners;
    private readonly InputHandler _inputHandler;

    public SpawnerHandler(List<EnemySpawner> spawners, InputHandler inputHandler)
    {
        _spawners = spawners;
        _inputHandler = inputHandler;
        _inputHandler.ChangeFactory += OnChangeFactory;
    }

    public void InitSpawners(FactoryHandler factoryHandler)
    {
        foreach (EnemySpawner enemySpawner in _spawners)
        {
            enemySpawner.Init(factoryHandler);
        }
    }

    private void OnChangeFactory()
    {
        foreach (EnemySpawner enemySpawner in _spawners)
        {
            enemySpawner.ChangeFactory();
        }
    }

    public void Dispose()
    {
        _inputHandler.ChangeFactory -= OnChangeFactory;
    }
}