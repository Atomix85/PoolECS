using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ObjectType
{
    Player,
    Ennemy
}

public class Pool
{
    private List<PoolableObject> poolableObjects;

    public void Initialize(PoolableObject a, int parNumber)
    {
        poolableObjects = new List<PoolableObject>(parNumber);
        poolableObjects.Add(a);
    }

    public PoolableObject getObject(int index)
    {
        return poolableObjects[index];
    }
}
