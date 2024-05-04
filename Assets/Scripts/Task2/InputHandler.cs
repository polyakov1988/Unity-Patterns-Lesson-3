using System;
using UnityEngine;

namespace Task2
{
    public class InputHandler : MonoBehaviour
    {
        public event Action ChangeFactory;
    
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                ChangeFactory?.Invoke();
            }
            
        }
    }
}