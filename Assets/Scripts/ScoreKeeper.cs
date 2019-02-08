using UnityEngine;
using System.Collections;

public class ScoreKeeper : Singleton<ScoreKeeper> {

	private float _timeRemaining;
	
	public float TimeRemaining 
	{
		get { return _timeRemaining; }
		set { _timeRemaining = value; }
	}

	private int _p1numCoins;
	
	public int P1NumCoins {
		get { return _p1numCoins; }
		set { _p1numCoins = value; }
	}

    private int _p2numCoins;
	
	public int P2NumCoins {
		get { return _p2numCoins; }
		set { _p2numCoins = value; }
	}

    private int _p3numCoins;
	
	public int P3NumCoins {
		get { return _p3numCoins; }
		set { _p3numCoins = value; }
	}
	
	private float maxTime = 5 * 60; // In seconds.

	// Use this for initialization
	void Start () {
		TimeRemaining = maxTime;
	}
	
	// Update is called once per frame
	void Update () {
		TimeRemaining -= Time.deltaTime;

		if (TimeRemaining <= 0)
		{
			Application.LoadLevel(Application.loadedLevel);
			TimeRemaining = maxTime;
		}
	}
}
