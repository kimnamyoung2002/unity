using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Note : MonoBehaviour
{

    public float NoteSpeed = 400;
    public GameObject noteObject;
    // Start is called before the first frame update
    void Start()
    {
        noteObject = GetComponent<GameObject>();
    }


    void Update()
    {
        transform.localPosition += Vector3.right * NoteSpeed * Time.deltaTime;
    }
}
