using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CritterSpawner : MonoBehaviour
{

    public ICopyable m_Copy;

    public Critter SpawnCritter(Critter prototype)
    {
        m_Copy = prototype.Copy();
        return (Critter)m_Copy;
    }

}
