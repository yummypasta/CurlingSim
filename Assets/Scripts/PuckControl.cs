using UnityEngine;
using System.Collections;

public class PuckControl : MonoBehaviour
{
    public enum state
    {
        toss,
        glide
    }
    public Vector2 initForce;
    public float threshold;
    public float dragIncrease;
    state puckState;
    Rigidbody2D rigid;

    // Use this for initialization
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        puckState = state.toss;
    }

    // Update is called once per frame
    void Update()
    {
        if (puckState == state.toss)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.touchCount > 0)
            {
                Debug.Log("Whee! Init glide!");
                rigid.AddForce(initForce);
                puckState = state.glide;
                
            }
        }
        else if(puckState == state.glide)
        {
            //rigid.AddForce(new Vector2(0, (Input.GetTouch(0).deltaPosition.x + Input.GetTouch(0).deltaPosition.y) * 12));
            if (Input.GetKeyDown(KeyCode.Z))
            {
                Debug.Log("addforce");
                rigid.AddForce(new Vector2(0, 10));
            }
            if(rigid.velocity.y < threshold)
            {
                Debug.Log("u ded get shrekt");
            }
            rigid.drag += dragIncrease;
        }
    }
}
