namespace Task5
{
    public class RaceStatProvider : IStatProvider
    {
        private readonly IStatProvider _statProvider;
        private readonly RaceType _raceType;

        public RaceStatProvider(IStatProvider statProvider, RaceType raceType)
        {
            _statProvider = statProvider;
            _raceType = raceType;
        }

        public PlayerStat GetStats()
        {
            PlayerStat playerStat = _statProvider.GetStats();

            switch (_raceType)
            {
                case RaceType.Human:
                    break;
                
                case RaceType.Elf:
                    playerStat.ChangeIntelligence(OperationType.Add, 4);
                    break;
                
                case RaceType.Ork:
                    playerStat.ChangeStrength(OperationType.Multiply, 1.2f);
                    break;
            }
            
            return playerStat;
        }
    }
}
