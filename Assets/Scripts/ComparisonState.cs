using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComparisonState : MonoBehaviour
{

    public GameObject player;
    public GameObject enemy;
    public State enemyState;
    public State playerState;
    private Animator playeranimator;

    // Start is called before the first frame update
    void Awake()
    {
        enemyState = enemy.GetComponent<EnumState>().currentState;    
        playerState = player.GetComponent<EnumState>().currentState;
        playeranimator = player.GetComponent<Animator>();
    }

    public void ChangeState()
    {
        
        if (playerState == enemyState)
        {
            Debug.Log("good");
        }

        else
        {
            //screenshake
            playeranimator.SetTrigger("Hit");
        }
    }
}
