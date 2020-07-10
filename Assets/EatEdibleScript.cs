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
        if (other.gameObject.layer==LayerMask.NameToLayer("Player"))
        {
            text.text = ScoreModuleScript.ScoreUp().ToString();
            Destroy(gameObject);
        }
    }

}
