using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadFastestTime : MonoBehaviour
{
    public ScoreManager scoreManager;
    public Text track1Text;
    // Start is called before the first frame update
    void Start()
    {
        track1Text.text = "Fastest Time: " + scoreManager.bestTime;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
