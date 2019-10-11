using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Critter : MonoBehaviour, ICopyable
{

    public ICopyable Copy()
    {
        return Instantiate(this);
    }

    public void setSprintingBehavior()
    {
        var m_Animator = gameObject.GetComponent<Animator>();
        RuntimeAnimatorController sprintingAnimationController = Resources.Load<RuntimeAnimatorController>("Sprinting");
        Debug.Log("move critter: " + sprintingAnimationController);
        m_Animator.runtimeAnimatorController = sprintingAnimationController;
    }

    public void setJumpingBehavior()
    {
        var m_Animator = gameObject.GetComponent<Animator>();
        RuntimeAnimatorController jumpingAnimationController = Resources.Load<RuntimeAnimatorController>("Jumping");
        Debug.Log("move critter: " + jumpingAnimationController);
        m_Animator.runtimeAnimatorController = jumpingAnimationController;
    }

    public void setShakingBehavior()
    {
        var m_Animator = gameObject.GetComponent<Animator>();
        RuntimeAnimatorController shakingAnimationController = Resources.Load<RuntimeAnimatorController>("Shaking");
        Debug.Log("move critter: " + shakingAnimationController);
        m_Animator.runtimeAnimatorController = shakingAnimationController;
    }


}
