using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{

    public float moveSpeed = 10f;
    private Rigidbody rbody;
    private Renderer rend;
    private Light myLight;


    // Use this for initialization
    void Start()
    {

        rbody = GetComponent<Rigidbody>();
        rend = GetComponent<Renderer>();
        myLight = GetComponent<Light>();

    }

    // Update is called once per frame
    void Update()
    {
        //What we are pressing
        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");

        //How fast we are moving
        float moveX = inputX * moveSpeed * Time.deltaTime;
        float moveZ = inputZ * moveSpeed * Time.deltaTime;

        //Telling the ball to move
        //transform.Translate(moveX, 0f, moveZ);

        rbody.AddForce(moveX, 0f, moveZ);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Wall1")
        {
            rend.material.color = Color.green;
            myLight.color = Color.green;

        }
        else if (collision.collider.name == "Wall2")
        {
            rend.material.color = Color.blue;
            myLight.color = Color.blue;

        }
        else if (collision.collider.name == "Wall3")
        {
            rend.material.color = Color.red;
            myLight.color = Color.red;
        }
        else if (collision.collider.name == "Wall4")
        {
            rend.material.color = Color.yellow;
            myLight.color = Color.yellow;
        }
    }
}
