using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class MyHandController : MonoBehaviour
{
    [SerializeField] private InputActionProperty actionTrigger;
    [SerializeField] private InputActionProperty actionGrip;
    private Animator handAnimator;

    private void Start()
    {
        handAnimator = GetComponent<Animator>();
    }

    private void Update()
    {
        float triggerValue = actionTrigger.action.ReadValue<float>();
        float gripValue = actionGrip.action.ReadValue<float>();

        handAnimator.SetFloat("Trigger",triggerValue);
        handAnimator.SetFloat("Grip",gripValue);
    }
}