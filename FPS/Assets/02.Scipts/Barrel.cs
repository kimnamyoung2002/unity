using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour
{
    Rigidbody rb;
    float hitCount = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Bullet"))
        {
            hitCount++;
            if(hitCount == 3)
            {
                Collider[] colliders = Physics.OverlapSphere(transform.position, 15f, 1 << 8);

                foreach (var collider in colliders) 
                {
                    var _rb = collider.GetComponent<Rigidbody>();
                    _rb.mass = 1f;
                    _rb.AddExplosionForce(1200f, transform.position, 15f, 1000f);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
