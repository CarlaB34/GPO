using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    

    public float speedPlayer;
   
    private Rigidbody rb;

    private Vector3 moveInput;
    private Vector3 velocity;
    private float moveVelocity;
    private Vector3 moveDirectionX = Vector3.right;
    private Vector3 moveDirectionZ = Vector3.forward;
    private PickObject pickBj;

    public Animation animMarch;

    private void Start()
    {
        pickBj = GetComponent<PickObject>();
        rb = GetComponent<Rigidbody>();
    }


    private void Update()
    {
        moveVelocity = 0;
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.Q))
        {
            transform.rotation = Quaternion.Euler(0, -90, 0 * speedPlayer);
            GetComponent<Rigidbody>().AddForce(moveDirectionX * -speedPlayer, ForceMode.Impulse);
            

        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(0, 90, 0 * speedPlayer);
            transform.rotation = Quaternion.Euler(0, 90, 0 * speedPlayer);
            GetComponent<Rigidbody>().AddForce(moveDirectionX * speedPlayer, ForceMode.Impulse);

        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Euler(0, -180, 0 * speedPlayer);
            GetComponent<Rigidbody>().AddForce(moveDirectionZ * -speedPlayer, ForceMode.Impulse);


        }

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Z))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0 * speedPlayer);
            transform.rotation = Quaternion.Euler(0, 0, 0 * speedPlayer);
            GetComponent<Rigidbody>().AddForce(moveDirectionZ * speedPlayer, ForceMode.Impulse);

        }
        Vector3 velocity = GetComponent<Rigidbody>().velocity;

        GetComponent<Rigidbody>().velocity = velocity + new Vector3(moveVelocity, 0);

       
    }
    private void FixedUpdate()
    {
        rb.velocity = velocity;
    }



}
