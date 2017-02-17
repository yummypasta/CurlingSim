using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HiscoreText : MonoBehaviour {
    public string pre = "High Score: ";
    public Text txt;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        txt.text = pre + PlayerPrefs.GetFloat("highscore", 0).ToString();

    }
    public void ClearHighScore()
    {
        PlayerPrefs.DeleteKey("highscore");

    }
}
