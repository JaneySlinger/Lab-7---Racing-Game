using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadFastestTime : MonoBehaviour
{
    public ScoreManager scoreManager;
    public Text track1Text;
    public Text track2Text;
    public Button Track2Button;
    // Start is called before the first frame update
    void Start()
    {
        Track2Button.enabled = false;
        if(scoreManager.bestTimes[0] < 50.0f){
            Track2Button.enabled = true;
        }
        track1Text.text = "Fastest Time: " + scoreManager.bestTimes[0];
        track2Text.text = "Fastest Time: " + scoreManager.bestTimes[1];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
