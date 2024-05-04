using UnityEngine;

namespace Task3
{
    public class SpawnPoint : MonoBehaviour
    {
        public bool IsFree { get; private set; }

        public void SetBusy() => IsFree = false;

        private void Awake()
        {
            IsFree = true;
        }
    }
}