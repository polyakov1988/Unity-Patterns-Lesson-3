using UnityEngine;
using UnityEngine.XR;

namespace Task5
{
    public class PlayerStat
    {
        public PlayerStat(float strength, float agility, float intelligence)
        {
            Strength = strength;
            Agility = agility;
            Intelligence = intelligence;
            
            Debug.Log("Базовые статы: ");
            ShowStat();
        }

        public float Strength { get; private set; }
        public float Agility { get; private set; }
        public float Intelligence { get; private set; }

        public void ShowStat()
        {
            Debug.Log(Strength);
            Debug.Log(Agility);
            Debug.Log(Intelligence);
        }

        public void ChangeStrength(OperationType operationType, float operationValue)
        {
            Strength = ChangeStat(Strength, operationType, operationValue);
        }
        
        public void ChangeAgility(OperationType operationType, float operationValue)
        {
            Agility = ChangeStat(Agility, operationType, operationValue);
        }
        
        public void ChangeIntelligence(OperationType operationType, float operationValue)
        {
            Intelligence = ChangeStat(Intelligence, operationType, operationValue);
        }

        private float ChangeStat(float oldValue, OperationType operationType, float operationValue)
        {
            switch (operationType)
            {
                case OperationType.Multiply:
                    return oldValue * operationValue;
                
                case OperationType.Add:
                    return oldValue + operationValue;
                
                default:
                    return oldValue;
            }
        }
    }
}
