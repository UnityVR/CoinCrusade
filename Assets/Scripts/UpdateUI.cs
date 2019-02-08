using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UpdateUI : MonoBehaviour {

	private GameObject canvasPC;
	private GameObject canvasIOS;

	[SerializeField]
	private Text timerLabel;

	[SerializeField]
	private Text p1Label;

    [SerializeField]
	private Text p2Label;

    [SerializeField]
	private Text p3Label;

	// Use this for initialization
	void Start () {
		// #if UNITY_IOS
    //   		canvasIOS = GameObject.FindWithTag("CanvasIOS");
		// 	canvasIOS.SetActive(true);
    // 	#endif

		// #if UNITY__STANDALONE_OSX
    //   		canvasPC = GameObject.FindWithTag("CanvasPC");
		// 	canvasPC.SetActive(true);
    // 	#endif
	}
	
	// Update is called once per frame
	void Update () {
		timerLabel.text = FormatTime (ScoreKeeper.Instance.TimeRemaining);
		p1Label.text = "Player 1: " + ScoreKeeper.Instance.P1NumCoins.ToString ();
		p2Label.text = "Player 2: " + ScoreKeeper.Instance.P2NumCoins.ToString ();
		p3Label.text = "Player 3: " + ScoreKeeper.Instance.P3NumCoins.ToString ();
	}

	private string FormatTime(float timeInSeconds)
	{
		return string.Format("{0}:{1:00}", Mathf.FloorToInt(timeInSeconds/60), Mathf.FloorToInt(timeInSeconds % 60));
	}
}
