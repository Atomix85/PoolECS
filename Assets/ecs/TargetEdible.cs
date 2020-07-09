using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TargetEdible : Composant
{

    public GameObject player;
    public NavMeshAgent _Navmesh;

    public void Start()
    {

        _Navmesh = player.GetComponent<NavMeshAgent>();
        
        Accessor<TargetEdible>.Instance().AddModule(this);

    }

    public override void Run()
    {
        _Navmesh.SetDestination(this.transform.position);
    }
}
