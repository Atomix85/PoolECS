using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowTarget : MonoBehaviour
{
    [SerializeField]
    public Transform target;

    private NavMeshAgent _navMeshAgent;
    
    
    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();

        Debug.Log(this);
        
        Accessor<FollowTarget>.Instance().AddModule(this);
    }

    public void Run()
    {
        Debug.DrawLine(_navMeshAgent.destination, new Vector3(_navMeshAgent.destination.x, _navMeshAgent.destination.y + 1f, _navMeshAgent.destination.z), Color.green);
        if (target != null)
        {
            _navMeshAgent.isStopped = false;
            _navMeshAgent.SetDestination(target.position);
        }
        else
        {
            _navMeshAgent.isStopped = true;
        }
        
        /*if (_navMeshAgent.isStopped)
        {
            
        }*/
    }
    
}
