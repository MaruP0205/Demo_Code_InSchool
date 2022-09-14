using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move2 : MonoBehaviour
{
    void OnTriggerEnter2D (Collider2D col)
	{
		GameControl.moneyAmount += 2;
		Destroy (gameObject);
	}
}
