using UnityEngine;
using System.Collections;

public class PuckControl : MonoBehaviour
{
    public enum state
    {
        toss,
        glide
    }
    state puckState;
    // Use this for initialization
    void Start()
    {
        puckState = state.toss;
    }

    // Update is called once per frame
    void Update()
    {
        if (puckState == state.toss)
        {
            if(Input.touchCount > 0)
            {

            }
        }
    }
}
