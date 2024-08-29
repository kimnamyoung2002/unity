using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public GameObject PrfHpbar;
    public GameObject canvas;
    public string enemyName;
    public int maxHp;
    public int nowHp;
    public int atkDmg;
    public int atkSpeed;

    RectTransform HpBar;

    public float height = 1.7f;

    private void SetEnemyStatus(string _enemyName, int _maxHp, int _atkDmg, int _atkSpeed)
    {
        enemyName = _enemyName;
        maxHp = _maxHp;
        nowHp = _maxHp;
        atkDmg = _atkDmg;
        atkSpeed = _atkSpeed;
    }


    // Start is called before the first frame update
    void Start()
    {
        HpBar = Instantiate(PrfHpbar,canvas.transform).GetComponent<RectTransform>();
        if(name.Equals("Enemy1"))
        {
            SetEnemyStatus("Enemy1", 100, 20, 20);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 _hpBarPos = Camera.main.WorldToScreenPoint(new Vector3(transform.position.x, transform.position.y + height, 0));

        HpBar.position = _hpBarPos;
    }
}
