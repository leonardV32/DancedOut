using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatePlayer : MonoBehaviour
{

    private State startingState = State.Idle;
    public State currentState;
    public bool canMove = true;

    private Animator animator;
    
    private void Awake()
    {
        animator = GetComponent<Animator>();
        //Debug.Log(animator.GetCurrentAnimatorStateInfo(0).);
        currentState = startingState;
        
    }


    /*private void Update()
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
    }*/

    public void DoIdle()
    {   
        if (canMove)
        {
            currentState = State.Idle;
            canMove = false;
        }
           
    }

    public void DoJab()
    {
        if (canMove)
        {
            currentState = State.Jab;
            canMove = false;
        }
    }

    public void DoDirect()
    {
        if (canMove)
        {
            currentState = State.Direct;
            canMove = false;
        }
    }

    public void DoBodyshot()
    {
        if (canMove)
        {
            currentState = State.Bodyshot;
            canMove = false;
        }
    }

    public void DoUppercut()
    {
        if (canMove)
        {
            currentState = State.Uppercut;
            canMove = false;
        }
    }

    public void DoHit()
    {
        currentState = State.Hit;
    }


    public void LockInput()
    {
        canMove = false;
    }

    public void UnlockInput()
    {
        canMove = true;
    }
}
