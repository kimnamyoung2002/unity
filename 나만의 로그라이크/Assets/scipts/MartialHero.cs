using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms;
using static UnityEngine.GraphicsBuffer;

public class MartialHero : MonoBehaviour
{
    public float movePower = 1f;

    public int maxHp;
    public int nowHp;
    public int atkDmg;
    public bool attacked = false;
    public Image nowHpbar;

    public Animator Martialanimator; // 사용할 애니메이터 컴포넌트
    public Rigidbody2D rigid;

    // Start is called before the first frame update
    void Start()
    {
        maxHp = 100;
        nowHp = 100;
        atkDmg = 10;

        Martialanimator = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        martialHeromove();
        nowHpbar.fillAmount = (float)nowHp / (float)maxHp;
    }

    public void martialHeroattack()
    {
        if (Input.GetKeyDown("q"))
        {
            Martialanimator.SetTrigger("attack");
        }

        if (Input.GetKeyDown("w"))
        {
            Martialanimator.SetTrigger("attack2");
        }
    }

    public void martialHeroback()
    {
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
    }
    public void martialHeromove()
    {
        Vector3 moveVelocity = Vector3.zero;

        if (Input.GetAxisRaw("Horizontal") == 0)
        {
            Martialanimator.SetBool("Move", false);
        }

        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            moveVelocity = Vector3.left;
            Martialanimator.SetBool("Move", true);
        }

        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            moveVelocity = Vector3.right;
            Martialanimator.SetBool("Move", true);
        }

        transform.position += moveVelocity * movePower * Time.deltaTime;
    }
}

