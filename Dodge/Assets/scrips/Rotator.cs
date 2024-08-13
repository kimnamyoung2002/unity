using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float r_speed = 60f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, r_speed * Time.deltaTime, 0f);
    }
}
