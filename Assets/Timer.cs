using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour


{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField]  float remainingTime;
    public GameEnding gameEnding;
    bool IsTimerUp;
    bool IsGameDone;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
            IsTimerUp = false;
        }
        else if (remainingTime < 0)
        {
            remainingTime = 0;
            timerText.color = Color.red;
            IsTimerUp = true;
        }
        remainingTime -= Time.deltaTime; 
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        if (IsTimerUp == true)
        {
            gameEnding.CaughtPlayer();
        }
    }
}
