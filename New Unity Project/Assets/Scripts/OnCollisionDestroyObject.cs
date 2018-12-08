using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionDestroyObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	private void OnCollisionEnter(Collision collision)
	{
		//Debug.Log(collision.collider.name);
		if (collision.gameObject.name == "rey")
		{
			Destroy(gameObject);
		}	
	}
	// Update is called once per frame
	void Update () {
		
	}
}
