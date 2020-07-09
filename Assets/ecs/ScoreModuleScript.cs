using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreModuleScript : MonoBehaviour
{
    public int _score;
    
    [SerializeField]
    private GameObject player;
    
    void Start()
    {
        _score = 0;
    }



    public void Run()
    {
        throw new System.NotImplementedException();
    }
}
