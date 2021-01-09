using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MovementData
{
    public float MaxSpeed;
    public float MovementForce;
    public float JumpHeight;
}

[System.Serializable]
public class HealthData
{
    public float MaxHealth;
    public float InitialDamage;
}
[CreateAssetMenu(fileName = "Character Data", menuName = "Character Data Example", order = 1)]
public class CharacterData : ScriptableObject
{
    public MovementData MovementData = new MovementData();
    public HealthData HealthData = new HealthData();
}
