using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OnCollisionDestroyObject : MonoBehaviour
{



	private int health = 10;
	// Use this for initialization
	void Start () {
		
	}
	public void Dead(string sceneName)
	{
		{
			SceneManager.LoadScene("You Are Dead");	
		}
		
	}

	private void OnCollisionEnter(Collision collision)
	{
		//Debug.Log(collision.collider.name);
		if (collision.gameObject.name == "Porg Left")
		{
			//SceneManager.LoadScene("You Are Dead");
			Destroy(gameObject);
			SceneManager.LoadScene("You Are Dead");
		}

		if (collision.gameObject.name == "Porg Right")
		{
			Destroy(gameObject);
		}

		if (collision.gameObject.name == "Porg Front")
		{
			Destroy(gameObject);
		}

		if (collision.gameObject.name == "luke")
		{
			print("YOU HAVE SUCCESSFULLY GIVEN LUKE HIS LIGHTSABER. YOU WIN!");
		}

		//if (collision.gameObject.name == "Falling Rock")
		{
		//	Destroy(gameObject);
		}
	}
	// Update is called once per frame
	void Update () {

		print(health);
	}
}
