using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LukeCollision : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}

	public void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.name == "rey")
		{
			Debug.Log("YOU SUCCESSFULLY GAVE LUKE HIS LIGHTSABER!");
		}
	}

	// Update is called once per frame
	void Update () {

		
	}
}
