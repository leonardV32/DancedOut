using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumState : MonoBehaviour
{
   public enum State
    {   
        Idle,
        Jab,
        Direct,
        Bodyshot,
        Uppercut
    }

    private State state = State.Idle;
    public int currentState;
    public GameObject PlayerBodyShot;
    public GameObject PlayerJab;
    public GameObject PlayerUpper;
    public GameObject PlayerDirect;

    private Animator animator;
    private Rigidbody2D rb2D;
    private SpriteRenderer spriterenderer;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }


    private void Update()
    {
        switch (state)
        {
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


    public void DoJab()
    {
        animator.SetTrigger("Jab");
    }
    
    public void DoDirect()
    {
        animator.SetTrigger("Direct");
    }

    public void DoBodyshot()
    {
        animator.SetTrigger("Bodyshot");
    }

    public void DoUppercut()
    {
        animator.SetTrigger("Uppercut");
    }
    /*public void OnJab(currentState)
    {
        State currentState = State.Jab;
        animator.
    }*/
}
