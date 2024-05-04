namespace Task5
{
    public class SpecialtyStatProvider : IStatProvider
    {
        private readonly IStatProvider _statProvider;
        private readonly SpecialtyType _specialtyType;

        public SpecialtyStatProvider(IStatProvider statProvider, SpecialtyType specialtyType)
        {
            _statProvider = statProvider;
            _specialtyType = specialtyType;
        }

        public PlayerStat GetStats()
        {
            PlayerStat playerStat = _statProvider.GetStats();

            switch (_specialtyType)
            {
                case SpecialtyType.Thief:
                    playerStat.ChangeAgility(OperationType.Add, 10);
                    break;
                
                case SpecialtyType.Magician:
                    playerStat.ChangeIntelligence(OperationType.Multiply, 1.5f);
                    break;
                
                case SpecialtyType.Barbarian:
                    playerStat.ChangeStrength(OperationType.Add, 7);
                    break;
            }
            
            return playerStat;
        }
    }
}
