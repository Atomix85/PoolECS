using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class System : IUpdater
{
    public void Run()
    {
        Accessor<Composant> modules = new Accessor<Composant>();
        foreach (var module in modules.GetAllModules())
        {
            GameObject go = module;
            
        }
    }
}

public interface IUpdater
{
    void Run();
}
