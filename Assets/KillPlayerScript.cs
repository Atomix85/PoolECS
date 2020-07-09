using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayerScript : Composant
{
    public GameObject player;


    public override void Run()
    {
        if (this.transform.position == player.transform.position)
        {
            Destroy(player);
        }
    }
}
