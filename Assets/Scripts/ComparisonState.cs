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

    private void FixedUpdate()
    {
        enemyState = enemy.GetComponent<EnumState>().currentState;
        playerState = player.GetComponent<EnumState>().currentState;
    }
    public void ChangeState()
    {
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
