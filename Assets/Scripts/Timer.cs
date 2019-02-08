using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : Singleton<Timer>
{
    private float _timeRemaining;
    public float TimeRemaining
    {
        get { return _timeRemaining; }
        set { _timeRemaining = value; }
    }
    private float maxTime = 1 * 60; // in seconds

    // Start is called before the first frame update
    void Start()
    {
        TimeRemaining = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        TimeRemaining -= Time.deltaTime;
        // if (TimeRemaining <= 0) {
        //     Application.LoadLevel(Application.loadedLevel);
        //     TimeRemaining = maxTime;
        // }
    }
}
