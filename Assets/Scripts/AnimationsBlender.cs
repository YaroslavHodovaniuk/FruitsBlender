using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationsBlender : MonoBehaviour
{
    private Animator Animator;
    private void Start()
    {
        Animator = GetComponent<Animator>();
    }
    public void ButtonActionAnim()
    {
        Animator.SetTrigger("Trigger");
    }
}
