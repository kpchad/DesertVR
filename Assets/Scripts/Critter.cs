using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Critter : MonoBehaviour, ICopyable
{
    private Animator anim;
    public ICopyable Copy()
    {
        return Instantiate(this);
    }

    public void Awake()
    {
        anim = gameObject.GetComponent<Animator>();
        Debug.Log(anim);
    }

    public void setSprintingBehavior()
    {
        var m_Animator = gameObject.GetComponent<Animator>();
        RuntimeAnimatorController sprintingAnimationController = Resources.Load<RuntimeAnimatorController>("Sprinting");
        Debug.Log("move critter: " + sprintingAnimationController);
        m_Animator.runtimeAnimatorController = sprintingAnimationController;
    }

    public void setAttackBehavior()
    {
        var m_Animator = gameObject.GetComponent<Animator>();
        m_Animator.Play("Attack", -1, 0f);
        Debug.Log("Idle ");
    }

    public void setIdleBehavior()
    {
        var m_Animator = gameObject.GetComponent<Animator>();
        m_Animator.Play("Idle", -1, 0f);
        Debug.Log("Idle ");
    }

    public void setSlitherBehavior()
    {
        anim = gameObject.GetComponent<Animator>();
        Debug.Log(anim);
        anim.Play("Slither", -1, 0f);
        Debug.Log("slither " + anim);
    }

}
