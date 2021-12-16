using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComparisonState : MonoBehaviour
{

    /*[HideInInspector]*/ public GameObject player;
    /*[HideInInspector]*/ public GameObject enemy;
    public State enemyState;
    public State playerState;
    private Animator playeranimator;

    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.FindWithTag("Player");
        enemy = GameObject.FindWithTag("Enemy");
        playeranimator = player.GetComponent<Animator>();
    }



    /*A l'input check si y'a un changemetn proche.*/
    public void CheckState()
    {
        enemyState = enemy.GetComponent<StateEnemy>().currentState;
        playerState = player.GetComponent<StatePlayer>().currentState;
        if (enemyState == State.Idle) { Debug.Log("Idle dont touche me !");  return; }
        // check changestate avant ou après l'input
        if (playerState == enemyState)
        {
            Debug.Log("good");
        }

        else
        {
            //screenshake
            playeranimator.SetTrigger("Hit");
            Debug.Log("false move");
        }
    }
}
