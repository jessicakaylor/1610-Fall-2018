using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PorgLeft : MonoBehaviour
{
	public float EnemySpeed = 0.1f;
	public CharacterController Controller;

	
	
	private Vector3 location;
	
	// Use this for initialization
	void Start ()
	{

	}



	// Update is called once per frame
	void Update () {
		transform.Translate(-EnemySpeed, 0f, 0f);
	}
}
