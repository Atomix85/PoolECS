using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ECSmanager : MonoBehaviour
{
    public IUpdater updater = new SystemUpdate();
    
    
    // Update is called once per frame
    void Update()
    {
        updater.Run();
    }
}
