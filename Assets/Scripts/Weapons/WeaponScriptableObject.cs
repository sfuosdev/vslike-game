using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WeaponScriptableObject", menuName = "ScriptableObjects/Weapon")]
public class WeaponScriptableObject : ScriptableObject
{
    public GameObject prefab;
    //Base stats for the weapon
    public float damage;
    public float speed;
    public float cooldownDuration;
    public int pierce;
    
}
