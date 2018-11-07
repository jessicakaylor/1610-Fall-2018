using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventRepeat : MonoBehaviour
{

	public UnityEvent[] OnRepeat;
	
	public float Seconds = 2;
	private int i = 0;
	
	void Start ()
	{
		while (true)
		{
			yield return new WaitForSeconds(2);
			if (i < OnRepeat.Length-1)
			{
				i++;
			}
			else
			{
				i = 0;
			}
		
		
			
		}
	}
	
}
