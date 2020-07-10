using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TargetEdible : MonoBehaviour
{

    public GameObject player;
    public NavMeshAgent _Navmesh;

    public GameObject ennemy;
    
    public bool isFollow = true;
    
    public GameObject[] billes = GameObject.FindGameObjectsWithTag("bille");
    
    public void Start()
    {
        Accessor<TargetEdible>.Instance().AddModule(this);
    }

}
