using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using static UnityEngine.GraphicsBuffer;

public class MartialHero : MonoBehaviour
{

    public float jumpForce = 200f; // 점프 힘
    private int jumpCount = 0; // 누적 점프 횟수
    public float moveSpeed;

    private bool isMove = false; // 바닥에 닿았는지 나타냄

    public Animator Martialanimator; // 사용할 애니메이터 컴포넌트
    public Rigidbody2D playerRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        Martialanimator = GetComponent<Animator>();
        playerRigidbody = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        martialHeroMove();

        if (Input.GetKeyDown("q") && isMove)
        {
            Martialanimator.SetTrigger("attack");
        }

        if (Input.GetKeyDown("w") && isMove)
        {
            Martialanimator.SetTrigger("attack2");
        }

    }

    public void martialHeroMove()
    {
        if ((Input.GetKeyDown("left") && jumpCount < 1.0f) || (Input.GetKeyDown("right") && jumpCount < 1.0f))
        {
            jumpCount++;

            playerRigidbody.velocity = Vector2.zero;

            float horizontalForce = Input.GetAxis("Horizontal") * moveSpeed;

            playerRigidbody.AddForce(new Vector2(horizontalForce, jumpForce));
        }
        if (Input.GetKeyDown("up"))
        {
            if (transform.localEulerAngles.y == 180)
            {
                transform.localEulerAngles = new Vector3(0, 0, 0);
            }

            else if (transform.localEulerAngles.y == 0)
            {
                transform.localEulerAngles = new Vector3(0, 180, 0);
            }
        }

        Martialanimator.SetBool("Move", isMove);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 바닥에 닿았음을 감지하는 처리
        if (collision.contacts[0].normal.y > 0.7f)
        {
            isMove = true;
            jumpCount = 0;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        // 바닥에서 벗어났음을 감지하는 처리
        isMove = false;
    }

}