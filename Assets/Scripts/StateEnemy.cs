using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateEnemy : MonoBehaviour
{
    private State startingState = State.Idle;
    public State currentState;

    private Animator animator;


    private void Awake()
    {
        animator = GetComponent<Animator>();
        //Debug.Log(animator.GetCurrentAnimatorStateInfo(0).);
        currentState = startingState;
    }
    public void EnemyIdle()
    {
        animator.SetTrigger("Idle");
        //currentState = State.Idle; set in the animator
    }

    public void EnemyJab()
    {
        animator.SetTrigger("Jab");
        //currentState = State.Jab; set in the animator
    }

    public void EnemyDirect()
    {
        animator.SetTrigger("Direct");
        //currentState = State.Direct; set in the animator
    }

    public void EnemyBodyshot()
    {
        animator.SetTrigger("Bodyshot");
        //currentState = State.Bodyshot; set in the animator
    }

    public void EnemyUppercut()
    {
        animator.SetTrigger("Uppercut");
        //currentState = State.Uppercut; set in the animator

    }
}
