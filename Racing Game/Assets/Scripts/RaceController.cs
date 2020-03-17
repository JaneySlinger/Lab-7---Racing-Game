using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RaceController : MonoBehaviour
{
    public Text resultText;
    public Text timeText;
    RaceState raceState;
    private float startTime;
    public GameObject car;
    public int laps = 3;
    private int times_crossed = 0;


    enum RaceState
    {
        START,
        RACING,
        FINISHED
    };

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(startCountDown());
        raceState = RaceState.START;
    }

    IEnumerator startCountDown()
    {
        int count = 3;
        while(count >0)
        {
            resultText.text = "" + count;
            count--;
            yield return new WaitForSeconds(1);
        }
        raceState = RaceState.RACING;
        startTime = Time.time;
        resultText.text = "GO";

        yield return new WaitForSeconds(1);
        resultText.enabled = false;
    }


    // Update is called once per frame
    void Update()
    {
        if(raceState == RaceState.RACING)
        {
            timeText.text = "Time: " + (Time.time - startTime);
        }
    }

    private void OnTriggerEnter(Collider other) {
        //check if the car has passed over the start/finish line
        if (other.gameObject == car)
        {
            Debug.Log("Crossed line");
            if (times_crossed < laps && times_crossed > 0)
            {
                resultText.enabled = true;
                //a lap has been completed, but not the final lap
                resultText.text = "" + (laps - times_crossed);
            } else
            {
                //final lap
                resultText.text = "FINISH";
            }
            times_crossed++;
        }
        
    }

}
