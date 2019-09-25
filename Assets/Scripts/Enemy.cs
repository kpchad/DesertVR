using UnityEngine;

public class Enemy : MonoBehaviour, ICopyable
{

    public ICopyable Copy()
    {
        return Instantiate(this);
    }

}
