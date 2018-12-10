using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObject : MonoBehaviour
{
	public GameObject BlasterShotPrefab = null;

	// Use this for initialization
	void Start()
	{
	}

	// Update is called once per frame
	void Update()

	{
		if (Input.GetKeyDown(KeyCode.DownArrow))

		{
			Instantiate(
				BlasterShotPrefab,
				gameObject.transform.position,
				Quaternion.identity);
			{
				//if (Input.GetKeyDown(KeyCode.DownArrow))

				{
					//Instantiate(
					//BlasterShotPrefab,
					//gameObject.position,
					//Quaternion.identity);
				}
			}
		}
	}
}
