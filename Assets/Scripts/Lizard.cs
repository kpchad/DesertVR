using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lizard : Critter
{

    void Awake()
    {
        this.critterBehavior = new JumpingBehavior();
    }

}
