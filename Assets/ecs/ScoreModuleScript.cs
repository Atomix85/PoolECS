﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreModuleScript : MonoBehaviour
{
    public static int _score;

    void Start()
    {

        _score = 0;

    }
    
    public static void ScoreUp()
    {
        _score+=100;
        Debug.Log(_score);
    }
}
