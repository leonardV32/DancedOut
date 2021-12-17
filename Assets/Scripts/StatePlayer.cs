using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatePlayer : MonoBehaviour
{

    private State startingState = State.Idle;
    public State currentState;
    public bool canMove = true;

    

    public AudioClip sonJab;
    public AudioClip sonDirect;
    public AudioClip sonBodyshot;
    public AudioClip sonUppercut;
    public AudioClip sonHit;

    private AudioSource audioSource;

    private void Awake()
    {

        audioSource = this.GetComponent<AudioSource>();
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
            audioSource.clip = sonJab;
            canMove = false;
        }
    }

    public void DoDirect()
    {
        if (canMove)
        {
            currentState = State.Direct;
            audioSource.clip = sonDirect;
            canMove = false;
        }
    }

    public void DoBodyshot()
    {
        if (canMove)
        {
            currentState = State.Bodyshot;
            audioSource.clip = sonBodyshot;
            canMove = false;
        }
    }

    public void DoUppercut()
    {
        if (canMove)
        {
            currentState = State.Uppercut;
            audioSource.clip = sonUppercut;
            canMove = false;
        }
    }

    public void DoHit()
    {
        currentState = State.Hit;
        audioSource.clip = sonHit;
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
