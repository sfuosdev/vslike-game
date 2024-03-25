using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public CharacterScriptableObject characterData;

    //Current stats
    float currentHP;

    public float CurrentHP 
    { 
        get => currentHP; 
        set
        {
            if(currentHP != value)
            {
                currentHP = value; 
            }
        }
    }

    // XP and level of the player
    [Header("Expereince/Level")]
    public int XP = 0;
    public int level = 1;
    public int XPCap;

    // class for defining a level range and the experience cap increase for that range
    [System.Serializable]
    public class LevelRange
    {
        public int startLevel;
        public int endLevel;
        public int XPCapIncrease;
    }

    public List<LevelRange> levelRanges;

    void Awake()
    {
        CurrentHP = characterData.MaxHP;
    }

    void Start()    
    {
        //initialize the experience cap as the first xp cap increase
        XPCap = levelRanges[0].XPCapIncrease;
    }

    public void IncreaseXP(int amount)
    {
        XP += amount;
        LevelUpChecker();
    }

    void LevelUpChecker()
    {
        if(XP >= XPCap)
        {
            level++;
            XP -= XPCap;

            int XPCapIncrease = 0;
            foreach(LevelRange range in levelRanges)
            {
                if(level >= range.startLevel && level <= range.endLevel)
                {
                    XPCapIncrease = range.XPCapIncrease;
                    break;
                }
            }
            XPCap += XPCapIncrease;
        }
    }
}
