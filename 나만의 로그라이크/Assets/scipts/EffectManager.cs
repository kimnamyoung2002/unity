using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EffectManager : MonoBehaviour
{
    [SerializeField] Animator NoteHitEffect;
    public void NoteEffcet()
    {
        NoteHitEffect.SetTrigger("Hit");
    }
}
