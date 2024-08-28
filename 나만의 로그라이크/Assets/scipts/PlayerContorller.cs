using System.Collections;
using System.Collections.Generic;
using UnityEditor;
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
        if (Input.GetKeyDown("left") || Input.GetKeyDown("right") || Input.GetKeyDown("q") || Input.GetKeyDown("w") || Input.GetKeyDown("e") || Input.GetKeyDown("r") || Input.GetKeyDown("up"))
        {
            theTimingManager.CheckTiming(); // 판정 체크
        }
    }
}
