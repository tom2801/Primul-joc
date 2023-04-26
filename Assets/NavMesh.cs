using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMesh : MonoBehaviour
{
    public Transform destination;
    private NavMeshAgent agent;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        Vector3 corner;
        if (7 % 2 == 0)
            corner = new Vector3(7 / 2, 1, 7 / 2);
        else corner = new Vector3(0.5f + 7 / 2, 1, 0.5f + 7 / 2);

        agent.SetDestination(corner);
    }
}
