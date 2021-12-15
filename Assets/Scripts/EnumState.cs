using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumState : MonoBehaviour
{

    private State startingState = State.Idle;
    public State currentState;
    

    private Animator animator;
    
    private void Awake()
    {
        animator = GetComponent<Animator>();
        currentState = startingState;

    }


    private void Update()
    {
        switch (currentState)
        {
            case State.Idle:
                DoIdle();

                break;
            case State.Jab:
                DoJab();

                break;
            case State.Direct:
                DoDirect();

                break;
            case State.Bodyshot:
                DoBodyshot();

                break;
            case State.Uppercut:
                DoUppercut();

                break;
            default:
                break;
        }
    }

    public void DoIdle()
    {
        animator.SetTrigger("Idle");
        currentState = State.Idle;
    }

    public void DoJab()
    {
        animator.SetTrigger("Jab");
        currentState = State.Jab;
    }

    public void DoDirect()
    {
        animator.SetTrigger("Direct");
        currentState = State.Direct;
    }

    public void DoBodyshot()
    {
        animator.SetTrigger("Bodyshot");
        currentState = State.Bodyshot;
    }

    public void DoUppercut()
    {
        animator.SetTrigger("Uppercut");
        currentState = State.Uppercut;
    }
   
}
