using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public CapsuleCollider capsule;
    public Rigidbody rb;
    public float MoveSpeed, AirMoveSpeed, JumpSpeed;
    private Vector3 velocity;
    private float currentSpeed;
    public LayerMask groundMask;
    public bool hasDoubleJump = true;
    public Vector3 Velocity
    {
        get
        {
            return velocity;
        }
    }

    public bool IsGrounded
    {
        get
        {
            return Physics.Raycast(this.transform.position, Vector3.down, 1.55f, groundMask);
        }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float XAxis = Input.GetAxis("Vertical");
        float YAxis = Input.GetAxis("Horizontal");
        velocity = (XAxis * transform.forward) + (YAxis * transform.right);
        velocity *= currentSpeed;
        rb.velocity = new Vector3(velocity.x, rb.velocity.y, velocity.z);


        if ((IsGrounded && Input.GetKeyDown(KeyCode.Space)) || (!IsGrounded && hasDoubleJump && Input.GetKeyDown(KeyCode.Q)))
        {
            rb.AddForce(Vector3.up * JumpSpeed);
            hasDoubleJump = false;
        }


        if (IsGrounded)
        {
            currentSpeed = Mathf.Lerp(currentSpeed, MoveSpeed, 5 * Time.deltaTime);
            hasDoubleJump = true;
        }
        else
        {
            currentSpeed = Mathf.Lerp(currentSpeed, AirMoveSpeed, Time.deltaTime);
        }


    }
}
