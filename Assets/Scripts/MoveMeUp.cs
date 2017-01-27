using UnityEngine;
using System.Collections;

public class MoveMeUp : MonoBehaviour
{
    public GameObject go;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnBecameInvisible()
    {
        transform.position = new Vector3(go.transform.position.x, go.transform.position.y, transform.position.z);
    }
}
