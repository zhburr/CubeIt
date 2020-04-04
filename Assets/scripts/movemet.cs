using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movemet : MonoBehaviour
{
    public Rigidbody rb;
    public float forwarSpeed = 300f;
    public float speed = 12f;
    public float leftedge=-9.5f;
    public float rightedge=10f;
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody>();
          
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal")*Time.deltaTime*speed;

        Vector3 newPosition = rb.position + Vector3.right * x;
        rb.MovePosition(newPosition);
       /* if(newPosition.x<leftedge)
        {
            transform.position = new Vector3(leftedge, transform.position.y, transform.position.z);
        }
        if (newPosition.x > rightedge)
        {
            transform.position = new Vector3(rightedge, transform.position.y, transform.position.z);
        }*/
        rb.AddForce(0, 0, forwarSpeed*Time.deltaTime);
        if (newPosition.y < -0.5f)
        {
            
            FindObjectOfType<EndGame>().end();
        }


    }
}
