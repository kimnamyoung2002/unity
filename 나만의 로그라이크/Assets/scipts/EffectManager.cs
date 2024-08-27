using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EffectManager : MonoBehaviour
{
    [SerializeField] Animator NoteHitEffect;
    [SerializeField] Animator JudgementEffect;
    public void NoteEffcet()
    {
        NoteHitEffect.SetTrigger("Hit");
    }

    public void Perfect()
    {
        JudgementEffect.SetTrigger("PerFect");
    }
    public void Cool()
    {
        JudgementEffect.SetTrigger("Cool");
    }
    public void Good()
    {
        JudgementEffect.SetTrigger("Good");
    }
    public void Bad()
    {
        JudgementEffect.SetTrigger("Bad");
    }
    public void Miss()
    {
        JudgementEffect.SetTrigger("Miss");
    }
}
