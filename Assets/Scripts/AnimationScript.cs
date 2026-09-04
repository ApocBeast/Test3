using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    public Animator animator;
    private string parameterName = "Integer";
    private string strafeDirection = "StrafeDirection";
    private string blend = "Blend";
    
    [Header("Number key pressed changes Animation ID (0-7) and")]
    [Header("triggers the corresponding animation specified below.")]
    
    public int animationID;
    float velocity = 0.0f;
    float strafeSlider = 0.5f;
    public float acceleration = 0.1f;
    public float deceleration = 0.5f;

    void Start()
    {
        // Cache the Animator component attached to this GameObject
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void Update()
    {
        int integer = animator.GetInteger("Integer");

        animator.SetFloat(blend, velocity);
        animator.SetFloat(strafeDirection, strafeSlider);

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
            // Running
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
            animator.SetFloat(strafeDirection, strafeSlider);
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            animationID = 5;
            animator.SetTrigger("Trigger");
            animator.SetTrigger("TurnAroundTrigger");
        }

        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            // Walking
            animationID = 6;
            animator.SetTrigger("Trigger");
        }

        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            animationID = 7;
            animator.SetTrigger("Trigger");
            animator.SetFloat(strafeDirection, strafeSlider);
        }

        if (animator != null)
        {
            animator.SetInteger(parameterName, animationID);
        }

        if (animationID == 2 && velocity < 1.0f)
        {
            velocity += Time.deltaTime * acceleration;
        }

        if (animationID != 2 && velocity > 0.0f)
        {
            velocity -= Time.deltaTime * deceleration;
        }

        if (animationID != 2 && velocity < 0.0f)
        {
            velocity = 0.0f;
        }

        if (animationID == 4 && strafeSlider > 0.0f)
        {
            strafeSlider -= Time.deltaTime * acceleration;
        }

        if (animationID == 7 && strafeSlider < 1.0f)
        {
            strafeSlider += Time.deltaTime * acceleration;
        }

        if (animationID != 4 && animationID != 7 && strafeSlider < 0.5f)
        {
            strafeSlider += Time.deltaTime * acceleration;
        }

        if (animationID != 4 && animationID != 7 && strafeSlider > 0.5f)
        {
            strafeSlider -= Time.deltaTime * acceleration;
        }
    }
}
