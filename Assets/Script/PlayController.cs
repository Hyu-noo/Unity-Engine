using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayController : MonoBehaviour
{
    public Rigidbody pr;
    public float speedd = 8f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            pr.AddForce(0f, 0f, speedd);
        }
        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            pr.AddForce(0f, 0f, -speedd);
        }
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            pr.AddForce(speedd, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            pr.AddForce(-speedd, 0f, 0f);
        }

    }
    public void Die()
    {
        gameObject.SetActive(false);
    }
}
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class PlayerController : MonoBehaviour
//{
//    public Rigidbody playerRigidBody;
//    public float speed = 8f;
//    // Start is called before the first frame update
//    void Start()
//    {
//        playerRigidBody = GetComponent<Rigidbody>();
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        float xInput = Input.GetAxis("Horizontal");
//        float zInput = Input.GetAxis("Vertical");

//        float xSpeed = xInput * speed;
//        float zSpeed = zInput * speed;


//        //Vector3.newVelocity = new Vector3(xSpeed, 0f, zSpeed);
//        // playerRigidBody.velocity = newVelocity;

//    }

//    public void Die()
//    {
//        gameObject.SetActive(false);
//    }
//}

