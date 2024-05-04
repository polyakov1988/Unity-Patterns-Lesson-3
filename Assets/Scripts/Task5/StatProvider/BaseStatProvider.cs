namespace Task5
{
    public class BaseStatProvider : IStatProvider
    {
        public PlayerStat GetStats()
        {
            return new PlayerStat(10, 10, 10);
        }
    }
}
