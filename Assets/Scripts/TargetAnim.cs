using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TargetAnim : MonoBehaviour {
	public float wait = 0.01f;
	public Vector3 add;
	public float thresh;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	


	}

	public IEnumerator GrowMe(){
		while (true) {
			transform.localScale += add;
			if(transform.localScale.x > thresh || transform.localScale.y > thresh)
				SceneManager.LoadScene("Menu");
			yield return new WaitForSeconds (wait);
		}
	}



}
