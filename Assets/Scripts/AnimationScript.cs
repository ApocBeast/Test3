using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    public Animator animator;
    private string parameterName = "Integer";
    
    [Header("Press [Spacebar] with the Game window active")]
    [Header("to trigger the animation ID (0-6) specified below.")]
    [Header("Number key pressed changes Animation ID.")]
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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Trigger");
        }

        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            animationID = 0;
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            animationID = 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            animationID = 2;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            animationID = 3;
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            animationID = 4;
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            animationID = 5;
        }

        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            animationID = 6;
        }

        if (animator != null)
        {
            animator.SetInteger(parameterName, animationID);
        }
    }
}
