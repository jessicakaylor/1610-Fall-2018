using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
   
    public CharacterController Controller;

    public float Gravity = 9.81f;
    public float JumpSpeed = 7.0f;
    public float MoveSpeed = 5.0f;
    public float FlipSpeed = 5.0f;

    private Vector3 location;
    private Vector3 rotation;

    //private Vector3 rotation;
    // Use this for initialization
    void Start()
    {
        Controller = GetComponent< CharacterController >();
    }
	
    // Update is called once per frame
    void Update()
    {  
        location.x = MoveSpeed * Input.GetAxis( "Horizontal" );
        location = transform.TransformDirection( location );
       
       // transform.Rotate(0, Input.GetAxis("Horizontal")*FlipSpeed*Time.deltaTime, 0);        

        if ( Controller.isGrounded )
        {
            location.y = JumpSpeed * Input.GetAxis("Vertical");

            if ( Input.GetButton( "Jump" ) )
            {
                location.y = JumpSpeed;
            }
        }
        
        location.y -= Gravity * Time.deltaTime;
        Controller.Move( location * Time.deltaTime );
    }
}