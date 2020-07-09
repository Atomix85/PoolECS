using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatEdibleScript : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        HandleCollision(other.gameObject);
    }
    
    private void HandleCollision(GameObject other)
    {
        if (other.gameObject.layer==LayerMask.NameToLayer("Player"))
        {
            
            Destroy(gameObject);
        }
    }

}
