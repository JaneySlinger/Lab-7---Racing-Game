using UnityEngine;

[CreateAssetMenu(fileName = "ScoreManagerData", menuName = "ScriptableObjects/ScoreManager", order = 1)]

public class ScoreManager : ScriptableObject
{
    public float[] bestTimes = {50.0f,200.0f};
    //public float bestTime1 = 50.0f;
    //public float bestTime2 = 200.0f;

    public void setTime(float newTime, int trackNumber)
    {
        if(bestTimes[trackNumber-1] > newTime){
            bestTimes[trackNumber-1] = newTime;
        }
    }
}
