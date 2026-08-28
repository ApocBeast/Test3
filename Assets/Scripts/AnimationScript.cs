using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    public Animator animator;
    private string parameterName = "Integer";
    
    [Header("Number key pressed changes Animation ID (0-7) and")]
    [Header("triggers the corresponding animation specified below.")]
    
    public int animationID;

    void Start()
    {
        // Cache the Animator component attached to this GameObject
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void Update()
    {
        int integer = animator.GetInteger("Integer");

        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            animationID = 0;
            animator.SetTrigger("Trigger");
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            animationID = 1;
            animator.SetTrigger("Trigger");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            animationID = 2;
            animator.SetTrigger("Trigger");
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            animationID = 3;
            animator.SetTrigger("Trigger");
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            animationID = 4;
            animator.SetTrigger("Trigger");
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            animationID = 5;
            animator.SetTrigger("Trigger");
        }

        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            animationID = 6;
            animator.SetTrigger("Trigger");
        }

        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            animationID = 7;
            animator.SetTrigger("Trigger");
        }

        if (animator != null)
        {
            animator.SetInteger(parameterName, animationID);
        }
    }
}
