using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Interactable : MonoBehaviour {
    
    NavMeshAgent playerAgent;
    Transform _Transform;
    bool hasInteracted;
    void Start()
    {
        _Transform = transform;
    }

	public virtual void MoveToInteraction(NavMeshAgent _PlayerAgent)
    {
        hasInteracted = false;
        playerAgent = _PlayerAgent;
        playerAgent.stoppingDistance = 2.5f;
        playerAgent.destination = _Transform.position;
    }

    void Update()
    {
        if(!hasInteracted && playerAgent != null && !playerAgent.pathPending)
        {
            if(playerAgent.remainingDistance <= playerAgent.stoppingDistance)
            {
                Interact();
                hasInteracted = true;
            }
        }
    }

    public virtual void Interact()
    {
        Debug.Log("Interacting with base class");
    }
}
