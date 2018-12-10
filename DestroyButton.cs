using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyButton : MonoBehaviour
{
	// Use this for initialization


	public GameObject objectToDestroy;
	public void DestroyGameObject()
	{	
		
		print("FIND LUKE AT THE TOP BUT WATCH OUT FOR PORGS!");
			Destroy(objectToDestroy);
	}

}
