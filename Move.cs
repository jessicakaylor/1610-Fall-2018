
using UnityEngine;

public class Move : MonoBehaviour
{
    public CharacterController Character;
    public float Speed;
    public Vector3 MoveSpeed;
	
	
    private void Update()
    {
        MoveSpeed.x += Speed*Input.GetAxis("Horizontal");
        MoveSpeed *= Time.deltaTime;
        MoveSpeed.y += Input.GetAxis("Vertical");
        Character.Move(MoveSpeed);
    }
}