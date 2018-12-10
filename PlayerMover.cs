using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;


public class PlayerMover : MonoBehaviour
{
   
    public CharacterController Controller;

    public float Gravity = 9.81f;
    public float JumpSpeed = 6.0f;
    public float MoveSpeed = 4.0f;
    public float FlipSpeed = 5.0f;
    public GameObject BlasterShotPrefab = null; 
   

    private Vector3 location;
    private Vector3 rotation;
    //public GameObject BlasterShotPrefab = null;

    //private Vector3 rotation;
    // Use this for initialization
    void Start()
    
    {
        //Instantiate()
        Controller = GetComponent< CharacterController >();
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
        }
       // if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //Instantiate(BlasterShotPrefab);
            // Instantiate(Bullet);
            // SystemSounds.Beep.Play();


        }
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