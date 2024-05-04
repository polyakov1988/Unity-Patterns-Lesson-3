using Task3;
using UnityEngine;

[CreateAssetMenu(fileName = "CoinFactory", menuName = "Factory/CoinFactory")]
public class CoinFactory : ScriptableObject
{
    [SerializeField] private Coin _coinPrefab;

    public Coin Get()
    {
        return Instantiate(_coinPrefab);
    }
}
