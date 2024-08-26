using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MartialHero : MonoBehaviour
{
    public Animator Martialanimator;

    // Start is called before the first frame update
    void Start()
    {
        Martialanimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            Martialanimator.SetTrigger("attack");
        }
    }

}
