using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TimingManager : MonoBehaviour
{
    public List<GameObject> boxNoteList = new List<GameObject>();
    public GameObject note;

    [SerializeField] Transform center = null; // ���� ������ �߽�
    [SerializeField] Transform[] timingRect = null; // �پ��� ���� ����
    Vector2[] timingBoxs = null; // ���� ���� �ּҰ� x, �ִ밪 y

    EffectManager effectmanager;
    MartialHero martialhero;

    void Start()
    {
        effectmanager = GetComponent<EffectManager>();
        martialhero = FindAnyObjectByType<MartialHero>();

        timingBoxs = new Vector2[timingRect.Length];

        for (int i = 0; i < timingRect.Length; i++)
        {
            float minX = center.localPosition.x - timingRect[i].localScale.x / 2;
            float maxX = center.localPosition.x + timingRect[i].localScale.x / 2;

            timingBoxs[i] = new Vector2(minX, maxX);
        }
    }

    public void CheckTiming()
    {
        for (int i = 0; i < boxNoteList.Count; i++)
        {
            float t_notePosX = boxNoteList[i].transform.localPosition.x;

            // ���� ���� : Perfect -> Cool -> Good -> Bad
            for (int j = 0; j < timingBoxs.Length; j++)
            {
                if (timingBoxs[j].x <= t_notePosX && t_notePosX <= timingBoxs[j].y)
                {
                    boxNoteList[i].SetActive(false);
                    effectmanager.NoteEffcet();

                    switch (j)
                    {
                        case 0:
                            effectmanager.Perfect();
                            martialhero.martialHeroattack();
                            if (Input.GetKeyDown("up"))
                            {
                                martialhero.martialHeroback();
                            }
                            break;
                        case 1:
                            effectmanager.Cool();
                            break;
                        case 2:
                            effectmanager.Good();
                            break;
                        case 3:
                            effectmanager.Bad();
                            break;
                    }
                    return;
                }
            }
        }
        effectmanager.Miss();
    }
}
