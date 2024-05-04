namespace Task5
{
    public class PassiveAbilityStatProvider : IStatProvider
    {
        private readonly IStatProvider _statProvider;
        private readonly PassiveAbilityType _passiveAbilityType;

        public PassiveAbilityStatProvider(IStatProvider statProvider, PassiveAbilityType passiveAbilityType)
        {
            _statProvider = statProvider;
            _passiveAbilityType = passiveAbilityType;
        }

        public PlayerStat GetStats()
        {
            PlayerStat playerStat = _statProvider.GetStats();

            switch (_passiveAbilityType)
            {
                case PassiveAbilityType.Secrecy:
                    playerStat.ChangeAgility(OperationType.Multiply, 2.4f);
                    break;
                
                case PassiveAbilityType.QuickLearning:
                    playerStat.ChangeIntelligence(OperationType.Add, 5);
                    break;
                
                case PassiveAbilityType.FireSword:
                    playerStat.ChangeStrength(OperationType.Add, 4);
                    break;
            }
            
            return playerStat;
        }
    }
}
