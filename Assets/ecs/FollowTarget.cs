using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowTarget : MonoBehaviour
{
    [SerializeField]
    public Transform target;

    public bool isFollow;
    
    public NavMeshAgent _navMeshAgent;
    
    
    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        isFollow = true;
        Debug.Log(this);
        
        Accessor<FollowTarget>.Instance().AddModule(this);
    }

    
}
