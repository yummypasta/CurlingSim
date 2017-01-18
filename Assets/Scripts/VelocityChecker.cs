using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class VelocityChecker : MonoBehaviour {
    Text txt;
    public Rigidbody2D body;
	// Use this for initialization
	void Start () {
        txt = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        txt.text = body.velocity.y.ToString();
	}
}
