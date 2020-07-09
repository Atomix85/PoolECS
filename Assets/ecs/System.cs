using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemUpdate : IUpdater
{
    public void Run()
    {
        Accessor<Composant> modules = Accessor<Composant>.Instance();
        foreach (var module in modules.GetAllModules())
        {
            module.Run();
        }
    }
}

public interface IUpdater
{
    void Run();
}
