using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PorgRight : MonoBehaviour
{
    public float EnemySpeed = 0.1f;
    public CharacterController Controller;

    private Vector3 location;
    private Vector3 position;
    
	
    // Use this for initialization
    void Start()
    {
    }

    
    // Update is called once per frame
    void Update ()
 
 
        {
            transform.Translate(EnemySpeed, 0f, 0f);   
        }
        
    
    }

