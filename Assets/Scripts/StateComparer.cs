using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateComparer : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;

    public State enemyState;
    public State playerState;

    private Animator playeranimator;

    void Awake()
    {
        player = GameObject.FindWithTag("Player");
        enemy = GameObject.FindWithTag("Enemy");
        playeranimator = player.GetComponent<Animator>();
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
        }

        else
        {
            switch (playerState)
            {
                case State.Idle:
                    
                    break;
                case State.Jab:
                    playeranimator.SetTrigger("Jab");

                    break;
                case State.Direct:
                    playeranimator.SetTrigger("Direct");

                    break;
                case State.Bodyshot:
                    playeranimator.SetTrigger("Bodyshot");

                    break;
                case State.Uppercut:
                    playeranimator.SetTrigger("Uppercut");

                    break;
                default:
                    break;
            }
        }

    }
}
