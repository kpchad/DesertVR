﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : Critter
{
    void Awake()
    {
        this.critterBehavior = new ShakingBehavior();
    }
}
