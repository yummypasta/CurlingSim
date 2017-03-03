using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageColorChange : MonoBehaviour {
	public List<Color> colors;
	public float wait;
	public float addPerTick;

	Image img;
	int current;
	int to;

	float lerp = 0;
	Coroutine cor;
	// Use this for initialization
	void Start () {
		img = GetComponent<Image> ();
		cor = StartCoroutine (ColorCycle ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator ColorCycle(){
		while (true) {
			img.color = Color.Lerp (colors [current], colors [to], lerp);
			lerp += addPerTick;

			if (lerp > 1) {
				lerp = 0;
				current = to;
				to++;
				if (to >= colors.Count) {
					to = 0;
				}
				StopCoroutine (cor); //commit suicide...
				cor = StartCoroutine(ColorCycle());
			}
			yield return new WaitForSeconds (wait);
		}
	}

}
