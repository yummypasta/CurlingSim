using UnityEngine;
using System.Collections;

public class SetPos : MonoBehaviour {
    public Transform other;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(other.position.x, other.position.y, transform.position.z);
	}
}
