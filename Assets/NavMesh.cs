using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMesh : MonoBehaviour
{
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
        if (Input.GetMouseButtonDown(1))
        {
            Ray movePosition = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(movePosition, out var hitInfo))
            {
                agent.SetDestination(hitInfo.point);
            }
        }
        
    }
}
