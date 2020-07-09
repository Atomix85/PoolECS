using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatEdibleScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        HandleCollision(other.gameObject);
    }

    private void OnCollisionEnter(Collision other)
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
}
