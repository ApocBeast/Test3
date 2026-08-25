using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    public Animator animator;
    private string parameterName = "Integer";
    
    [Header("Press [Spacebar] with the Game window active")]
    [Header("to trigger the animation ID (0-6) specified below.")]
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

        if (animator != null)
        {
            animator.SetInteger(parameterName, animationID);
        }
    }
}
