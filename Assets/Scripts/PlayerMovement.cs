using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public CapsuleCollider capsule;
    public Rigidbody rb;
    public float MoveSpeed, JumpSpeed;
    private Vector3 velocity;
    public LayerMask groundMask;
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
            return Physics.Raycast(this.transform.position, Vector3.down, 12f, groundMask);
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
        velocity = (XAxis * MoveSpeed * transform.forward) + (YAxis * MoveSpeed * transform.right);
        rb.velocity = new Vector3(velocity.x, rb.velocity.y, velocity.z);

        Debug.DrawLine(capsule.center, Vector3.down);

        if (IsGrounded && Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * JumpSpeed);
        }
    }
}
