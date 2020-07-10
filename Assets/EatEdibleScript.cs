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
        EdibleModule ediblescript = other.gameObject.GetComponent<EdibleModule>();
        if (ediblescript.edible == true)
        {
            ScoreModuleScript.ScoreUp();
            
            Destroy(other);
        }
    }

}
