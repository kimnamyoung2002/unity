using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    TimingManager theTimingManager;

    void Start()
    {
        theTimingManager = FindObjectOfType<TimingManager>();
    }

    void Update()
    {
        if (Input.GetKey("left") || Input.GetKey("right"))
        {
            theTimingManager.CheckTiming(); // 판정 체크
        }
    }
}
