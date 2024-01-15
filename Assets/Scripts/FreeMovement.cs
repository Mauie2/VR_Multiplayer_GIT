using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeMovement : MonoBehaviour
{
    public float speed;
    public float jumpHeight;
    public int rotation;
    public GameObject Player;
    Rigidbody rb;
    public bool grounded;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //if (Input.GetKey("d"))
        //{
        //    transform.Rotate(0, rotation * Time.deltaTime, 0);
        //}
        //if (Input.GetKey("a"))
        //{
        //    transform.Rotate(0, -rotation * Time.deltaTime, 0);
        //}

        rb.velocity = Vector3.zero;

        if (Input.GetKey("d"))
        {
            transform.Translate(Vector3.right.normalized * Time.deltaTime * speed, Space.Self);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(Vector3.left.normalized * Time.deltaTime * speed, Space.Self);
        }
        if (Input.GetKey("w"))
        {
            rb.velocity += new Vector3(transform.forward.x, 0, transform.forward.z).normalized * speed; 
        }
        if (Input.GetKey("s"))
        {
            rb.velocity += new Vector3(-transform.forward.x, 0, -transform.forward.z).normalized * speed;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (grounded)
            {
                rb.velocity += new Vector3(0, transform.forward.y, 0);
                grounded = false;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("je staat weer op de grond!");
        if (collision.gameObject.tag == "ground")
        {
            grounded = true;
        }
    }
}
