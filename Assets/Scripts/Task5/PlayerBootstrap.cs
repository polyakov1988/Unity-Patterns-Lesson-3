using UnityEngine;

namespace Task5
{
    public class PlayerBootstrap : MonoBehaviour
    {
        [SerializeField] private Player _player;

        private void Awake()
        {
            _player.Initialize(new RaceStatProvider(
                new SpecialtyStatProvider(
                    new PassiveAbilityStatProvider(
                        new BaseStatProvider(), PassiveAbilityType.Secrecy), 
                    SpecialtyType.Magician), 
                RaceType.Elf));
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                _player.PlayerStat.ShowStat();
        }
    }
}