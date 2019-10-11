using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Critter : MonoBehaviour, ICopyable
{
    protected ICritterBehavior critterBehavior;

    public void ApplyBehavior()
    {
        critterBehavior.Move();
    }

    public void SetCritterBehavior(ICritterBehavior moveType)
    {
        this.critterBehavior = moveType;
    }

    public ICopyable Copy()
    {
        return Instantiate(this);
    }

}
