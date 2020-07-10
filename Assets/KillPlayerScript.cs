using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayerScript : MonoBehaviour
{
	public bool isTarget = true;

	public TargetEdible targetEdible;
	
    private void OnTriggerEnter(Collider other)
	{
		HandleCollision(other.gameObject);
	}

	/*private void OnCollisionEnter(Collision other)
	{
		HandleCollision(other.gameObject);
	}*/
	
    private void HandleCollision(GameObject other)
    {
        if (other.gameObject.layer==LayerMask.NameToLayer("Player"))
        {
	        if(isTarget)
				Destroy(other);
	        else
	        {
		        targetEdible.isFollow = true;
		        Destroy(gameObject);
	        }
        }
    }
}
