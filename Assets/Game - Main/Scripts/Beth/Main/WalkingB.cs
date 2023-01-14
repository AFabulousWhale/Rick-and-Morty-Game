using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingB : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;
    public CharacterController controller;
    public float turnSpeed = 60.0f;
    public float walkSpeed;
    public float runSpeed = 200.0f;
    private Vector3 moveDirection = Vector3.zero;
    public float gravity = -75f;
    public float jumpHeight = 100f;
    public Vector3 move;

    Vector3 velocity;

    void Update()
    {
        if(controller.isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        move = transform.right * x + transform.forward * z;

        controller.Move(move * walkSpeed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

    }
}



