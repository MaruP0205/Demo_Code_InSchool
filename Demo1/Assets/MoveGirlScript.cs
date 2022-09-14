using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGirlScript : MonoBehaviour {

	float dirX;
	float dirY;
	Rigidbody2D rb,ra;
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		ra = GetComponent<Rigidbody2D> ();
	}
	
	void Update () {
		 if(Input.GetKey(KeyCode.D)){
            transform.Translate(Time.deltaTime * 8, 0 , 0);
            transform.localScale = new Vector3(0.4550455F,0.5037435F,0);
        }
        //left
        if(Input.GetKey(KeyCode.A)){
            transform.Translate(-Time.deltaTime * 8, 0 , 0);
            transform.localScale = new Vector3(0.4550455F,0.5037435F,0);
           
        } 
        //Jump
        if(Input.GetKey(KeyCode.W)){
            transform.Translate( 0,Time.deltaTime * 8 , 0);
            transform.localScale = new Vector3(0.4550455F,0.5037435F,0);
           
        }
		 if(Input.GetKey(KeyCode.S)){
            transform.Translate( 0,-Time.deltaTime * 8 , 0);
            transform.localScale = new Vector3(0.4550455F,0.5037435F,0);
           
        }
	//	dirX = Input.GetAxis ("Horizontal");
	//	dirY = Input.GetAxis ("Horizontal");
	}
/*	void FixedUpdate()
	{	
		if(Input.GetKey)
		rb.velocity = new Vector2 (dirX * 5, 0);
		rb.velocity = new Vector2 (0,dirX * 5);
	}*/

}
