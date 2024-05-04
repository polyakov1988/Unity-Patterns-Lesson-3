using System.Collections.Generic;
using System.Linq;

public class FactoryHandler
{
    private readonly Dictionary<RaceType, EnemyFactory> _factories;
    private readonly Queue<RaceType> _raceTypes;

    public FactoryHandler(Dictionary<RaceType, EnemyFactory> factories)
    {
        _factories = factories;
        _raceTypes = new Queue<RaceType>();
        
        foreach (RaceType factoriesKey in _factories.Keys)
        {
            _raceTypes.Enqueue(factoriesKey);
        }
    }

    public EnemyFactory GetFactory()
    {
        RaceType raceType = _raceTypes.Dequeue();
        
        return _factories[raceType];
    }
    
    public EnemyFactory GetOtherFactory(EnemyFactory currentFactory)
    {
        return _factories.Values.First(factory => factory.GetType() != currentFactory.GetType());
    }
}