﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(UnityEngine.AI.NavMeshAgent))]
public class AIBehavior : MonoBehaviour
{
    private WaitForFixedUpdate wffu = new WaitForFixedUpdate();
    private UnityEngine.AI.NavMeshAgent agent;
    public Transform player;
    private bool canHunt, canPatrol;
    public List<Transform> patrolPoints;
    private void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        StartCoroutine(Patrol());
    }

    private IEnumerator OnTriggerEnter(Collider other)
    {
        canHunt = true;
        canPatrol = false;
        agent.destination = player.position;
        var distance = agent.remainingDistance;
        while (distance <= 0.25f)
        {
            distance = agent.remainingDistance;
            yield return wffu;
        }
        yield return new WaitForSeconds(2f);

        StartCoroutine(canHunt ? OnTriggerEnter(other) : Patrol());
    }
    private void OnTriggerExit(Collider other)
    {
        canHunt = false;
        //StartCoroutine(Patrol());
    }
    
    private int i = 0;
    private IEnumerator Patrol()
    {
        canPatrol = true;
        while (canPatrol)
        {
            yield return wffu;
            if (agent.pathPending || !(agent.remainingDistance < 0.5f)) continue;
            agent.destination = patrolPoints[i].position;
            i = (i + 1) % patrolPoints.Count;
        }
    }
}
