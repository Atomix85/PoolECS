using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatEdibleScript : Composant
{
    
    
    
    private void OnTriggerEnter(Collider other)
    {
        HandleCollision(other.gameObject);
    }
    
    private void HandleCollision(GameObject other)
    {
        Debug.Log("Col!");
        if (other.gameObject.layer==LayerMask.NameToLayer("Player"))
        {
            Destroy(gameObject);
        }
    }

    public override void Run()
    {
        throw new System.NotImplementedException();
    }
}
