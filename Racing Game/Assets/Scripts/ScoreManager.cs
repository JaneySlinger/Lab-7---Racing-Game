﻿using UnityEngine;

[CreateAssetMenu(fileName = "ScoreManagerData", menuName = "ScriptableObjects/ScoreManager", order = 1)]

public class ScoreManager : ScriptableObject
{
    public float bestTime = 100.0f;

    public void setTime(float newTime, int trackNumber)
    {
        if(bestTime > newTime)
        {
            bestTime = newTime;
        }
    }
}
