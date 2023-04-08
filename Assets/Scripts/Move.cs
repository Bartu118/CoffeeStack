using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float hiz = 3;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        rb.velocity = new Vector3(0, 0, hiz);
       // gameObject.transform.position += new Vector3(0,0,hiz*Time.deltaTime);
        Movement();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Coffee")
        {   
            Vector3 xPos=collision.gameObject.transform.position;
            xPos.x=gameObject.transform.position.x;

            collision.gameObject.transform.parent= transform;
            collision.gameObject.transform.position = xPos;
            collision.gameObject.tag = "Player";
        }




    }

    private void Movement()
    {
        float x = Input.GetAxis("Horizontal") * 0.10f;
        Vector3 hareket = new Vector3(x, 0f, hiz * Time.deltaTime);
        transform.position = hareket + transform.position;
    }
}
