using System.Collections;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed;

    public float maxspeed = 1.0f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    /*
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3();

        if (Physics.gravity.x != 0.0f)
        {
            movement = new Vector3(0.0f, moveHorizontal, moveVertical);
        }
        else if (Physics.gravity.y != 0.0f)
        {
            movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        }

        rb.AddForce(movement * speed);

        if (rb.velocity.magnitude > maxspeed)
            rb.velocity = rb.velocity.normalized * maxspeed;
    }
    */

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);

        if (rb.velocity.magnitude > maxspeed)
            rb.velocity = rb.velocity.normalized * maxspeed;
    }
}