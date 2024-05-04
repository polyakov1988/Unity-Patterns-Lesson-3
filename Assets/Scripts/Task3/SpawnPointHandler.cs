using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Task3
{
    public class SpawnPointHandler
    {
        private readonly List<SpawnPoint> _spawnPoints;

        public event Action FreePointsEnded;

        public SpawnPointHandler(List<SpawnPoint> spawnPoints)
        {
            _spawnPoints = spawnPoints;
        }

        public Transform GetSpawnPoint()
        {
            List<SpawnPoint> freeSpawnPoints = _spawnPoints.FindAll(point => point.IsFree).ToList();
            
            if (freeSpawnPoints.Count == 1) 
                FreePointsEnded?.Invoke();
            
            SpawnPoint freeSpawnPoint = freeSpawnPoints[0];
            freeSpawnPoint.SetBusy();
            
            return freeSpawnPoint.transform;
        }
    }
}