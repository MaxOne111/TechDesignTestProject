using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayAnimation : MonoBehaviour, IPointerDownHandler
{
    private Animator _Animator;

    private void Awake()
    {
        _Animator = GetComponent<Animator>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        _Animator.SetTrigger("Jump");
    }
}
