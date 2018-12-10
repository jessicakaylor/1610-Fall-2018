using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class BlasterShot : MonoBehaviour
{

	public float Speed = 2f;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{	
		transform.Translate(Speed, 0, 0);
		
		
	}
}
	
