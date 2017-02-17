using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class VelocityChecker : MonoBehaviour {
    Text txt;
    public string pre;
    public Rigidbody2D body;
    public PuckControl pc;
    public bool timeMode;
	// Use this for initialization
	void Start () {
        txt = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        if (timeMode)
        {
            txt.text = pre + pc.time.ToString();
        }
        else
        {
            txt.text = pre + body.velocity.y.ToString();
        }
    }
}
