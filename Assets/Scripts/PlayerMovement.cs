using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour

{
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.18f * 2;
    public float jumpHeight = 3f;
    public float groundPoundVelocity = 10f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;
    bool isGroundPounding;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            controller.slopeLimit = 45.0f;
            velocity.y = -2f;
        }

        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 move = transform.right * x + transform.forward * z ;

        controller.Move(move.normalized * speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            controller.slopeLimit = 100f;
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        if(isGrounded && isGroundPounding)
        {
            isGroundPounding = false;
        }

        if (!isGrounded && !isGroundPounding && Input.GetButtonDown("Fire2"))
        {
            isGroundPounding = true;
            velocity.y -= groundPoundVelocity;
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
