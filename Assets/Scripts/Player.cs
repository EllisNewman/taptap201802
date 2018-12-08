using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 10f;
	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
	    if (transform.position.x < -2.5 && inputX < 0)
            return;
        if (transform.position.x > 2.5 && inputX > 0)
            return;
        transform.Translate(new Vector3(moveSpeed / 100f * inputX, moveSpeed / 100f * inputY,0));
	}
}
