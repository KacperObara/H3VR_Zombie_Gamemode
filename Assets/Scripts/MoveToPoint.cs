using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToPoint : MonoBehaviour
{
    public NavMeshAgent Agent;
    public Transform Waypoint;

    private void Start()
    {
        Agent.enabled = true;
    }

    void Update()
    {
        Agent.SetDestination(Waypoint.position);
    }
}