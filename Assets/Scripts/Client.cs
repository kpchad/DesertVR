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

    int x;
    int y;
    int z;
    int count = 0;

    public void Update()
    {
        
        if (count == 500)
        {
            m_Spawn = m_Spawner.SpawnEnemy(m_Lizard);
            m_Spawn.name = "Lizard_Clone_" + ++m_IncrementorLizard;

            // set coordinate range for objects to spawn within
            x = Random.Range(-100, 100);
            y = 5;
            z = Random.Range(-100, 100);
            Vector3 pos = new Vector3(x, y, z);

            m_Spawn.transform.Translate(pos);
            Debug.Log("X: " + x + " Y: " + y + " Z: " + z);
        }

        if (count == 1000)
        {
            m_Spawn = m_Spawner.SpawnEnemy(m_Snake);
            m_Spawn.name = "Snake_Clone_" + ++m_IncrementorSnake;

            // set coordinate range for objects to spawn within
            x = Random.Range(-150, 150);
            y = 5;
            z = Random.Range(-150, 150);
            Vector3 pos = new Vector3(x, y, z);

            m_Spawn.transform.Translate(pos);
            Debug.Log("X: " + x + " Y: " + y + " Z: " + z);
            count = 0;
        }
        count++;
    }
}
