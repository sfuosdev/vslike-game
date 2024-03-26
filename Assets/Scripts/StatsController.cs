using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StatsController : MonoBehaviour
{
    public TMP_Text LevelText;
    public TMP_Text HPText;
    public TMP_Text XPText;

    private PlayerStats playerStats;
    private float maxHP;

    void Start()
    {
        // getting PlayerStats component from scene
        playerStats = FindObjectOfType<PlayerStats>();
        maxHP = playerStats.characterData.MaxHP; 
        UpdateStatsUI(playerStats.level, playerStats.CurrentHP, playerStats.XP, playerStats.XPCap);
    }

    void UpdateStatsUI(int level, float hp, int xp, int xpCap)
    {
        // Text update
        LevelText.text = "Level " + level;
        HPText.text = hp + " / " + maxHP;
        XPText.text = xp + "/" + xpCap;
    }
}

