using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed=8f;
    private Rigidbody brb;
    // Start is called before the first frame update

    void Start()
    {
        speed = 8f;
        brb = GetComponent<Rigidbody>();
        brb.velocity = transform.forward * speed;
        Destroy(gameObject,3f); //3초 있다가 없애버림
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayController playerController = other.GetComponent<PlayController>();

            if (playerController != null){
                playerController.Die();
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
