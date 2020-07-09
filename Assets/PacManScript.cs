﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacManScript : MonoBehaviour
{

    public CharacterController Controller;
    public float speed = 12f;

    // Start is called before the first frame update
    void Awake()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        
        Vector3 move = transform.right*x+transform.forward *z;
        Controller.Move(move*speed*Time.deltaTime);
    }
}
