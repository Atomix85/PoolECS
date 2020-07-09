using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accessor<T>
{
    public static Accessor<T> Instance()
    {
        if(_instance == null) 
            _instance = new Accessor<T>();
        return _instance;
    }

    private static Accessor<T> _instance;

    private List<T> modules;

    public List<T> GetAllModules()
    {
        return modules;
    }

    public void AddModule(T module)
    {
        modules.Add(module);
    }
}
