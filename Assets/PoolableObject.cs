using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolableObject : MonoBehaviour
{
    private bool isInPool;
    
    // Start is called before the first frame update
     void Init()
    {
        gameObject.SetActive(true);
    }

     void DeInit()
     {
         gameObject.SetActive(false);
     }
}
