using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{

    public Lizard m_Lizard;
    public Snake m_Snake;
    public EnemySpawner m_Spawner;

    private Enemy m_Spawn;
    private int m_IncrementorLizard = 0;
    private int m_IncrementorSnake = 0;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            m_Spawn = m_Spawner.SpawnEnemy(m_Lizard);
            m_Spawn.name = "Lizard_Clone_" + ++m_IncrementorLizard;
            m_Spawn.transform.Translate(Vector3.forward * m_IncrementorLizard * 2.5f);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            m_Spawn = m_Spawner.SpawnEnemy(m_Snake);
            m_Spawn.name = "Snake_Clone_" + ++m_IncrementorSnake;
            m_Spawn.transform.Translate(Vector3.forward * m_IncrementorSnake * 2.5f);
        }
    }
}
