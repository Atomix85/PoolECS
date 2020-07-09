using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowTarget : Composant
{
    [SerializeField]
    public Transform target;

    private NavMeshAgent _navMeshAgent;
    
    // Start is called before the first frame update
    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        
        Accessor<Composant>.Instance().AddModule(this);
    }

    public override void Run()
    {
        _navMeshAgent.SetDestination(target.position);
        /*if (_navMeshAgent.isStopped)
        {
            
        }*/
    }
    
}
