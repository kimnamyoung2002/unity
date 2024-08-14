using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FireCtrl : MonoBehaviour
{
    public GameObject bullet;
    public Transform FirePos;

    public ParticleSystem catridge;
    public ParticleSystem muzzleFlash;

    void Start()
    {
        muzzleFlash = FirePos.GetComponentInChildren<ParticleSystem>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    void Fire()
    {
        Instantiate(bullet, FirePos.position, FirePos.rotation);

        catridge.Play();
        muzzleFlash.Play();

    }
}
