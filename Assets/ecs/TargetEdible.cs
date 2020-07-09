using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TargetEdible : Composant
{

    public GameObject player;
    public NavMeshAgent _Navmesh;

    public List<GameObject> billes;
    
    public void Start()
    {
        billes.AddRange(GameObject.FindGameObjectsWithTag("bille"));
        
        Accessor<TargetEdible>.Instance().AddModule(this);

    }

    public override void Run()
    {
        _Navmesh.isStopped = false;

        GameObject neareast = null;
        
        foreach (var bille in billes)
        {
            if (bille == null) continue;
            if (neareast == null || Vector3.Distance(transform.position, bille.transform.position) <
                Vector3.Distance(transform.position, neareast.transform.position))
            {
                neareast = bille;
            }
        }
        
        _Navmesh.SetDestination(neareast.transform.position);
    }
}
