using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandControl : MonoBehaviour
{
    public InputActionProperty pinchAninmationAction;
    public InputActionProperty gripAninmationAction;
    public Animator handAnimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float triggerValue = pinchAninmationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger", triggerValue);
        //UnityEngine.Debug.Log(triggerValue);
        float gripValue = gripAninmationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Grip", gripValue);
    }
}
