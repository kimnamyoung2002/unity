using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BallCtrl : MonoBehaviour
{
    Transform tr;
    Rigidbody rb;

    float h = 0f;
    float v = 0f;
    float Score = 0f;

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        Vector3 moveDir = new Vector3(h, 0f, v);
        //tr.Translate(moveDir * Time.deltaTime);
        rb.AddForce(moveDir.normalized * 5);

    }

    private void OnTriggerEnter(Collider other)
    {
        //print("OnTriggerEnter");//

        if (other.gameObject.CompareTag("Cube")){

            Score++;
            Destroy(other.gameObject);

            if(Score == 3)
            {
                print("YOU WIN");
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //print("OnCollisionEnter");
    }
}
