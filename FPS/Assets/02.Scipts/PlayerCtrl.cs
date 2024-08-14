using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PlayerAnim
{
    public AnimationClip idle;
    public AnimationClip runF;
    public AnimationClip runB;
    public AnimationClip runL;
    public AnimationClip runR;
}

public class PlayerCtrl : MonoBehaviour{   
    Transform tr;

    float h = 0f;
    float v = 0f;
    float j = 0f;
    float r = 0f;

    public float moveSpeed = 10f;
    public float rotSpeed = 200f;


    public PlayerAnim playerAnime;
    public Animation anime;

    void Start()
    {
        tr = GetComponent<Transform>();
        anime = GetComponent<Animation>();

        anime.clip = playerAnime.idle;
        anime.Play();
    }

    void Update()
    {
        h = Input.GetAxis("Horizontal");//수평(방향키 좌, 우)의 입력값을 h에 저장
        v = Input.GetAxis("Vertical");//수직(방향키 위, 아래)의 입력값을 v에 저장
        r = Input.GetAxis("Mouse X");
    
        Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h);

        tr.Translate(moveDir.normalized * moveSpeed * Time.deltaTime, Space.Self);

        tr.Rotate(Vector3.up * rotSpeed * r * Time.deltaTime);

        if(v >= 0.1f)
        {
            anime.CrossFade(playerAnime.runF.name, 0.3f);
        }

        else if(v <= -0.1f)
        {
            anime.CrossFade(playerAnime.runB.name, 0.3f);
        }

        else if (h >= 0.1f)
        {
            anime.CrossFade(playerAnime.runR.name, 0.3f);
        }

        else if(h <= -0.1f)
        {
            anime.CrossFade(playerAnime.runL.name, 0.3f);
        }
        else
        {
            anime.CrossFade(playerAnime.idle.name, 0.3f);
        }
        //     h = Input.SystemLanguage("Horizontal");//수평(방향키 좌, 우)의 입력값을 h에 저장
        //     v = Input.SystemLanguage("Vertical");//수직(방향키 위, 아래)의 입력값을 v에 저장
    }
}