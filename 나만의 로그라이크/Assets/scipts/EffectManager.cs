using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManager : MonoBehaviour
{
    [SerializeField] Animator NoteHitEffect = null;

    string Hit = "Hit";

    public void NoteEffcet()
    {
        NoteHitEffect.SetTrigger(Hit);
    }
}
