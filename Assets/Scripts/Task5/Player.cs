using UnityEngine;

namespace Task5
{
    public class Player : MonoBehaviour
    {
        public PlayerStat PlayerStat { get; private set; }
        
        public void Initialize(IStatProvider statProvider)
        {
            PlayerStat = statProvider.GetStats();
        }
    }
}