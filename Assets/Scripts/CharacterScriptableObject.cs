using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterScriptableObject", menuName = "ScriptableObjects/Character")]
public class CharacterScriptableObject : ScriptableObject
{
    // Starting Weapon

    // HP
    [SerializeField]
    float maxHP;
    public float MaxHP { get => maxHP; private set => maxHP = value; }

    // Movement Speed
}
