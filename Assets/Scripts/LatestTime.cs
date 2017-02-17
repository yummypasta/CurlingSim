using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LatestTime : MonoBehaviour {
	public string pretext;
	public Text t;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		t.text = pretext + ScoreManager.instance.latestScore.ToString();
	}
}
