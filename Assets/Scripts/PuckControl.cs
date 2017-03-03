using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class PuckControl : MonoBehaviour
{
    public enum state
    {
        toss,
        glide,
        end
    }
    public Vector2 initForce;
    public float threshold;
    public float dragIncrease;
    public float swipyMultiply;
    public GameObject target;
    state puckState;
    Rigidbody2D rigid;
    public float time = 0;
	public TargetAnim ta;
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
            rigid.drag *= dragIncrease;

            //rigid.AddForce(new Vector2(0, (Input.GetTouch(0).deltaPosition.x + Input.GetTouch(0).deltaPosition.y) * 12));
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("addforce");
                rigid.AddForce(new Vector2(0, 30));
              
            }/*
            for (int i = 0; i < Input.touchCount; i++)
            {
                rigid.AddForce(new Vector2(0, Math.Abs(Input.GetTouch(i).deltaPosition.x * swipyMultiply)));
            }*/
            time += Time.deltaTime;
            if (rigid.velocity.y < threshold)
            {
//                puckState = state.end;
            }
            if (transform.position.y > target.transform.position.y)
            {
                puckState = state.end;
            }
            if (Input.touchCount > 0)
            {
                rigid.AddForce(new Vector2(0, Math.Abs(Input.GetTouch(0).deltaPosition.x * swipyMultiply)));

                //rigid.AddForce(new Vector2(0, Math.Abs(Input.GetTouch(0).deltaPosition.y * swipyMultiply)));
            }
        }else if(puckState == state.end)
        {
			ScoreManager.instance.latestScore = time;
            if (time < PlayerPrefs.GetFloat("highscore", 99999999.99f))
            {
                PlayerPrefs.SetFloat("highscore", time);
                PlayerPrefs.Save();
            }
            Debug.Log("u ded get shrekt");
			rigid.velocity = Vector2.zero;
			StartCoroutine (ta.GrowMe());
			
        }
    }
}
