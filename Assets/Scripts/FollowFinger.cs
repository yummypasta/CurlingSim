using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowFinger : MonoBehaviour {
	public Collider2D cldr;
	public Rigidbody2D rb;
	AudioSource aud;
	// Use this for initialization
	void Start () {
		aud = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Input.mousePosition;
		aud.volume = (Input.touchCount > 0) ? 1 : 0;
		/*Vector3 pt = Camera.main.ScreenToWorldPoint (transform.position);
		pt = transform.TransformPoint (pt);
		pt.z = 0;
		Debug.Log (pt);
		if (cldr.bounds.Contains (pt)) {
			rb.velocity = Vector2.zero;
			Debug.Log ("WHOa there we are stopping velocity");
		}*/
	}
}
