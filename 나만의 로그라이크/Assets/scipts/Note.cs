using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Note : MonoBehaviour
{

    public float NoteSpeed = 400;
    public Image noteImage;
    // Start is called before the first frame update
    void Start()
    {
        noteImage = GetComponent<Image>();
    }

    public void HideNote()
    {
        noteImage.enabled = false;
    }

    void Update()
    {
        transform.localPosition += Vector3.right * NoteSpeed * Time.deltaTime;
    }
}
