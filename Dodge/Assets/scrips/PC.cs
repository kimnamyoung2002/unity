using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC : MonoBehaviour
{
    private Rigidbody pr;
    public float speed = 8.0f;

    // Start is called before the first frame update
    void Start()
    {
        pr = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float xinput = Input.GetAxis("Horizontal");
        float zinput = Input.GetAxis("Vertical");

        float xspeed = xinput * speed;
        float zspeed = zinput * speed;

        Vector3 nv = new Vector3(xspeed, 0f ,zspeed);
        pr.velocity = nv;
    }

    public void Die()
    {
        gameObject.SetActive(false);
        GameManager gm = FindObjectOfType<GameManager>();

        if(gm != null )
        { 
            gm.Endgame();
        }

    }
}
