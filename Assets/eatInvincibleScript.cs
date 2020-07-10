using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eatInvincibleScript : MonoBehaviour
{
    public FollowTarget followTarget;
    public TargetEdible targetEdible;
    public KillPlayerScript killPlayerScript;
    private void OnTriggerEnter(Collider other)
    {
        HandleCollision(other.gameObject);
    }
    
    private void HandleCollision(GameObject other)
    {
        if (other.gameObject.layer==LayerMask.NameToLayer("Player"))
        {
            followTarget.isFollow = false;
            targetEdible.isFollow = false;
            killPlayerScript.isTarget = false;
            
            Destroy(gameObject);
        }
    }
}
