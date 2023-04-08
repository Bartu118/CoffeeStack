using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coffee : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.parent == null)
        {
            gameObject.transform.tag = "Coffee";
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Coffee")
        {
            
            Vector3 xPos = collision.gameObject.transform.position;
            xPos.x = gameObject.transform.position.x;

            collision.gameObject.transform.parent = transform;
            collision.gameObject.transform.position = xPos;
            collision.gameObject.tag = "Player";
        }
    }


}
