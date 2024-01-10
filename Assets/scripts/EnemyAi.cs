using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAi : MonoBehaviour
{
    public NavMeshAgent ai;
    public List<Transform> destinations;
    public Animator aiAnim;
    public float walkSpeed, chaseSpeed, minIdleTime, maxIdleTime, idleTime;
    public bool walking, chasing;
    public Transform player;
    Transform currentDest;
    Vector3 dest;
    int randNum, randNum2;
    public int destinationAmount;


    
    void Start()
    {
        walking = true;
        randNum = Random.Range(0, destinationAmount);
        currentDest = destinations[randNum];
    }

    void Update()
    {
        if(walking == true)
        {
            dest = currentDest.position;
            ai.destination = dest;
            ai.speed = walkSpeed;
            if (ai.remainingDistance <= ai.stoppingDistance)
            {
                randNum2 = Random.Range(0, 2);
                currentDest = destinations[randNum];
            }
            if(randNum2 == 1)
            {
                aiAnim.ResetTrigger("walk");
                aiAnim.SetTrigger("idle");
                StopCoroutine("StayIdle");
                StartCoroutine("StayIdle");
                walking = false;
            }
        }
    }
    IEnumerator stayIdle()
    {
        idleTime = Random.Range(minIdleTime, maxIdleTime);
        yield return new WaitForSeconds(idleTime);
        walking = true;
        randNum2 = Random.Range(0, 2);
        currentDest = destinations[randNum];
        aiAnim.ResetTrigger("idle");
        aiAnim.SetTrigger("walk");
    }
}
