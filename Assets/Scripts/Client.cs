using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{

    public Lizard m_Lizard;
    public Snake m_Snake;
    public CritterSpawner m_Spawner;

    private Critter m_Spawn;
    private int m_IncrementorLizard = 0;
    private int m_IncrementorSnake = 0;

    int x;
    int y;
    int z;
    int count = 0;

    public void Update()
    {
        //// spawn a lizard or snake every 500 frames
        //if (count == 500)
        //{
        //    SpawnNewLizard();
        //}

        //if (count == 1000)
        //{
        //    SpawnNewSnake();
        //    count = 0;
        //} count++;

        // initialize game on I key press
        if (Input.GetKeyDown(KeyCode.I))
        {
            GameManager.Instance.InitializeGame();
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            // applying default critter behavior to critters
            Critter snakes = ScriptableObject.FindObjectOfType<Snake>();
            snakes.setJumpingBehavior();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            // applying default critter behavior to critters
            Critter lizards = ScriptableObject.FindObjectOfType<Lizard>();
            lizards.setShakingBehavior();
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            // applying sprinting behavior to critters
            Critter snakes = ScriptableObject.FindObjectOfType<Snake>();
            Critter lizards = ScriptableObject.FindObjectOfType<Lizard>();
            lizards.setSprintingBehavior();
            snakes.setSprintingBehavior();
        }

    }

    private void SpawnNewLizard()
    {

            m_Spawn = m_Spawner.SpawnCritter(m_Lizard);
            m_Spawn.name = "Lizard_Clone_" + ++m_IncrementorLizard;

            // set coordinate range for objects to spawn within
            x = Random.Range(-100, 100);
            y = 5;
            z = Random.Range(-100, 100);
            Vector3 pos = new Vector3(x, y, z);

            m_Spawn.transform.Translate(pos);
            Debug.Log("X: " + x + " Y: " + y + " Z: " + z);
    }

    private void SpawnNewSnake()
    {
        m_Spawn = m_Spawner.SpawnCritter(m_Snake);
        m_Spawn.name = "Snake_Clone_" + ++m_IncrementorSnake;

        // set coordinate range for objects to spawn within
        x = Random.Range(-150, 150);
        y = 5;
        z = Random.Range(-150, 150);
        Vector3 pos = new Vector3(x, y, z);

        m_Spawn.transform.Translate(pos);
        Debug.Log("X: " + x + " Y: " + y + " Z: " + z);
    }

}
