using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EatEdibleScript : MonoBehaviour
{
    

    public Text text;
    
    private void OnTriggerEnter(Collider other)
    {
        HandleCollision(other.gameObject);
    }
    
    private void HandleCollision(GameObject other)
    {
        EdibleModule ediblescript = other.gameObject.GetComponent<EdibleModule>();
        if (ediblescript.edible == true)
        {
            text.text = ScoreModuleScript.ScoreUp().ToString();
            Destroy(other);
        }
    }

}
