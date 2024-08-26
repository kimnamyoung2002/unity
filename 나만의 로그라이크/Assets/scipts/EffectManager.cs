using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EffectManager : MonoBehaviour
{
    public Animator NoteHitEffect;
    public void NoteEffcet()
    {
        NoteHitEffect.SetTrigger("Hit");
    }
}
