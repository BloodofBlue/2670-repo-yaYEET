
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMover : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 movement;
    public float gravity = 9.1f;
    public float moveSpeed;
    public float fastMoveSpeed = 6f;
    public float defaultMoveSpeed = 3f;
    public float jumpForce = 10f;
    public int jumpCountMax = 2;
    public Intdata canJump;
    
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal") * moveSpeed;
        movement.z = Input.GetAxis("Vertical") * moveSpeed;
        
        if (Input.GetKey(KeyCode.Y))
        {
            movement.x *= -moveSpeed;
        }

        if (Input.GetButtonDown("Jump") && jumpCountMax > 0 && canJump.value > 0)
        {
            movement.y = jumpForce;
            jumpCountMax -= 1;
        }

        else if (controller.isGrounded)
        {
            movement.y = -1;
            jumpCountMax = 2;
        }
        else
        {
            movement.y -= gravity;
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = fastMoveSpeed;
            print("wheeeeeeeee");
        }
        else
        {
            moveSpeed = defaultMoveSpeed;
        }
        
        movement = transform.TransformDirection(movement);
        controller.Move(movement * Time.deltaTime);
    }
}
