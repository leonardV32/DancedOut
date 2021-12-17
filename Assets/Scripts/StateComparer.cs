using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateComparer : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;

    public State enemyState;
    public State playerState;

    private StatePlayer statePlayer;

    private Animator playeranimator;
    private AudioSource audioSource;

    void Awake()
    {
        player = GameObject.FindWithTag("Player");
        enemy = GameObject.FindWithTag("Enemy");
        playeranimator = player.GetComponent<Animator>();
        audioSource = player.GetComponent<AudioSource>();
        statePlayer = player.GetComponent<StatePlayer>();
    }

    public void CheckState()
    {   
        enemyState = enemy.GetComponent<StateEnemy>().currentState;
        playerState = player.GetComponent<StatePlayer>().currentState;

        if (enemyState == State.Idle)
        {
            return;
        }

        if (enemyState != playerState)
        {
            playeranimator.SetTrigger("Hit");
            statePlayer.DoHit();
            audioSource.Play();

        }

        else
        {
            switch (playerState)
            {
                case State.Idle:
                    
                    break;
                case State.Jab:
                    playeranimator.SetTrigger("Jab");
                    audioSource.Play();

                    break;
                case State.Direct:
                    playeranimator.SetTrigger("Direct");
                    audioSource.Play();

                    break;
                case State.Bodyshot:
                    playeranimator.SetTrigger("Bodyshot");
                    audioSource.Play();

                    break;
                case State.Uppercut:
                    playeranimator.SetTrigger("Uppercut");
                    audioSource.Play();

                    break;
                default:
                    break;
            }
        }

    }
}
