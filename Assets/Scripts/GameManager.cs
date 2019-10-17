using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public Snake m_Snake;

    public void InitializeGame()
    {
        Debug.Log("initializing the game.");
    }

    // Start is called before the first frame update
    void Start()
    {
        m_Snake.setIdleBehavior();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J)) //change to "on release from grab"
        {
            // applying default critter behavior to critters
            m_Snake.setSlitherBehavior();
        }

        if (Input.GetKeyDown(KeyCode.A)) // change to "on grab"
        {
            // applying default critter behavior to critters
            m_Snake.setAttackBehavior();
        }
    }
}
